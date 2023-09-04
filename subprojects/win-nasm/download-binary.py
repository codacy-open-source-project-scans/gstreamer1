#!/usr/bin/env python3

import os
import sys
import ssl
import zipfile
import hashlib
import urllib.request
import urllib.error

# Disable certificate checking because it always fails on Windows
# We verify the checksum anyway.
ctx = ssl.create_default_context()
ctx.check_hostname = False
ctx.verify_mode = ssl.CERT_NONE

BASENAME = 'nasm-{}-{}.zip'
UPSTREAM_URL = 'https://www.nasm.us/pub/nasm/releasebuilds/{}/{}/{}'
GSTREAMER_URL = 'https://gstreamer.freedesktop.org/src/mirror/{}'

version = sys.argv[1]
arch = 'win64' if sys.argv[2] == 'x86_64' else 'win32'
zip_sha256 = sys.argv[3]
source_dir = os.path.join(os.environ['MESON_SOURCE_ROOT'], os.environ['MESON_SUBDIR'])
dest = BASENAME.format(version, arch)
dest_path = os.path.join(source_dir, dest)

def get_sha256(zipf):
    hasher = hashlib.sha256()
    with open(zipf, 'rb') as f:
        hasher.update(f.read())
    return hasher.hexdigest()

if os.path.isfile(dest_path):
    found_sha256 = get_sha256(dest_path)
    if found_sha256 == zip_sha256:
        print('{} already downloaded'.format(dest))
        sys.exit(0)
    else:
        print('{} checksum mismatch, redownloading'.format(dest))

for url in (GSTREAMER_URL.format(dest), UPSTREAM_URL.format(version, arch, dest)):
    print('Downloading {} to {}'.format(url, dest))
    try:
        with open(dest_path, 'wb') as d:
            f = urllib.request.urlopen(url, context=ctx)
            d.write(f.read())
        break
    except urllib.error.URLError as ex:
        print(ex)
        print('Failed to download from {!r}, trying mirror...'.format(url))
        continue
else:
    curdir = os.path.dirname(sys.argv[0])
    print('Couldn\'t download {!r}! Try downloading it manually and '
          'placing it into {!r}'.format(dest, curdir))

found_sha256 = get_sha256(dest_path)
if found_sha256 != zip_sha256:
    print('SHA256 of downloaded file {} was {} instead of {}'
          ''.format(dest, found_sha256, zip_sha256))
    sys.exit(1)

print('Extracting {}'.format(dest))
zf = zipfile.ZipFile(dest_path, "r")
zf.extractall(path=source_dir)

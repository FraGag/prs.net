# PRS compression/decompression library for the .NET Framework

This is a port of [fuzziqer's PRS compression/decompression utility](https://github.com/essen/prsutil) as a library targetting the Microsoft .NET Framework, version 2.0 or later.

The PRS compression algorithm is based on LZ77 with run-length encoding
emulation and extended matches. It is used in numerous games since the
introduction of the SEGA Saturn, including Phantasy Star Universe inside
the nbl file format.
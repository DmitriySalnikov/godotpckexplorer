@echo off
cd mbedtls

set PATH=C:\Program Files\Python39;%PATH%

echo PERL and PYTHON 3.6-3.9 is required
python --version

title Preparing

python -m ensurepip
python -m pip install --user -r scripts/basic.requirements.txt

python scripts\generate_driver_wrappers.py || exit /b 1
perl scripts\generate_errors.pl || exit /b 1
perl scripts\generate_query_config.pl || exit /b 1
perl scripts\generate_features.pl || exit /b 1
python scripts\generate_ssl_debug_helpers.py || exit /b 1
perl scripts\generate_visualc_files.pl || exit /b 1
python scripts\generate_psa_constants.py || exit /b 1

set CPUs=%NUMBER_OF_PROCESSORS%

title x64
cmake -G "Visual Studio 17 2022" -A x64 -S . -B "build64"
cmake --build build64 --config Debug -j %CPUs%
cmake --build build64 --config Release -j %CPUs%

title x86
cmake -G "Visual Studio 17 2022" -A win32 -S . -B "build32"
cmake --build build32 --config Debug -j %CPUs%
cmake --build build32 --config Release -j %CPUs%

title Install x64
cmake --install build64 --prefix ../libs

move /Y ..\libs\lib ..\libs\x64

title Install x86
cmake --install build32 --prefix ../libs

move /Y ..\libs\lib ..\libs\x86

rmdir /s /q ..\libs\bin
rmdir /s /q ..\libs\include
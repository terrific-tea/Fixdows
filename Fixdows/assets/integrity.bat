@echo off
title Fixdows Integrity Check script
echo Running sfc
sfc /scannow 
echo Running DISM
DISM /Online /Cleanup-Image /ScanHealth
DISM /Online /Cleanup-Image /RestoreHealth 
echo Done! Press any key to exit.
pause >nul
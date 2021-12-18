; Script generated with the Venis Install Wizard

; Define your application name
!define APPNAME "JF-Secure"
!define APPNAMEANDVERSION "JF-Secure 3.1"

; Main Install settings
Name "${APPNAMEANDVERSION}"
InstallDir "$PROGRAMFILES\JF-Secure"
InstallDirRegKey HKLM "Software\${APPNAME}" ""
OutFile "..\..\..\JF\OutFile.exe"

; Modern interface settings
!include "MUI.nsh"

!define MUI_ABORTWARNING
!define MUI_FINISHPAGE_RUN "$INSTDIR\JF Secure.exe"

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_LICENSE "License.txt"
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

; Set languages (first is default language)
!insertmacro MUI_LANGUAGE "English"
!insertmacro MUI_RESERVEFILE_LANGDLL

Section "JF-Secure" Section1

	; Set Section properties
	SetOverwrite on

	; Set Section Files and Shortcuts
	SetOutPath "$INSTDIR\"
	File "Caddy License.txt"
	File "JF Secure.exe"
	File "License.txt"
	File "ReadMe.md"
	File "caddy.exe"
	File "nssm.exe"
	CreateShortCut "$DESKTOP\JF-Secure.lnk" "$INSTDIR\JF Secure.exe"
	CreateDirectory "$SMPROGRAMS\JF-Secure"
	CreateShortCut "$SMPROGRAMS\JF-Secure\JF-Secure.lnk" "$INSTDIR\JF Secure.exe"
	CreateShortCut "$SMPROGRAMS\JF-Secure\Uninstall.lnk" "$INSTDIR\uninstall.exe"

SectionEnd

Section -FinishSection

	WriteRegStr HKLM "Software\${APPNAME}" "" "$INSTDIR"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "DisplayName" "${APPNAME}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "UninstallString" "$INSTDIR\uninstall.exe"
	WriteUninstaller "$INSTDIR\uninstall.exe"

SectionEnd

; Modern install component descriptions
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
	!insertmacro MUI_DESCRIPTION_TEXT ${Section1} ""
!insertmacro MUI_FUNCTION_DESCRIPTION_END

;Uninstall section
Section Uninstall

	;Remove from registry...
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}"
	DeleteRegKey HKLM "SOFTWARE\${APPNAME}"

	; Delete self
	Delete "$INSTDIR\uninstall.exe"

	; Delete Shortcuts
	Delete "$DESKTOP\JF-Secure.lnk"
	Delete "$SMPROGRAMS\JF-Secure\JF-Secure.lnk"
	Delete "$SMPROGRAMS\JF-Secure\Uninstall.lnk"

	; Clean up JF-Secure
	Delete "$INSTDIR\Caddy License.txt"
	Delete "$INSTDIR\JF Secure.exe"
	Delete "$INSTDIR\License.txt"
	Delete "$INSTDIR\ReadMe.md"
	Delete "$INSTDIR\caddy.exe"
	Delete "$INSTDIR\nssm.exe"

	; Remove remaining directories
	RMDir "$SMPROGRAMS\JF-Secure"
	RMDir "$INSTDIR\"

SectionEnd

BrandingText "JF-Secure: Easy Reverse Proxy for Jellyfin"

; eof
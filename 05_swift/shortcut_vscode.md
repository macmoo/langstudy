## VSCode 단축키

1. 검색 관련
* 파일 탐색: cmd + P
* 문자열 전체 탐색: cmd + shift + F
* 파일 내 검색: cmd + shift + O
* 다음/이전 검색 결과로 이동: cmd + G / shift + cmd + G
* 검색된 상태에서 아래로 내려가기: cmd + ↓
* 현재파일에서 바꾸기: opt + cmd + F
* 전체파일에서 바꾸기: shift + cmd + H
* 현재파일 심볼 이름 바꾸기: F2
* 해당 폴더 안에서 검색: option + shift + F
 

1. 포커싱/탐색
* 코파일럿 챗 오픈 & 포커싱: ctrl + cmd + i
* 코파일럿 챗 클로즈 / 오픈: option + cmd + B
* 코파일럿 챗 agent / ask 모드 선택: cmd + .
* 커밋 그래프로 포커싱: ctrl + shift + G
* 현재 파일로 Explorer 포커싱: cmd + shift + E
* 탐색기에서 파일 포커싱: cmd + ↓
* 이전/다음 위치로 커서 이동: ctrl + -
* 다음 라인으로 커서 이동: cmd + enter
* 소스 편집기로 바로 포커싱: cmd + 1~9
 

3. 창/탭 이동
* 탭 닫기: cmd + W
* 탭 다 닫기: cmd + K 누른 후 W
* 닫은 탭 다시 열기: cmd + shift + T
* 창분할: cmd + \
* 창이동: cmd + 1~9
* 탭이동: ctrl + 1~9


4. 기타
* 터미널 열기/닫기: cmd + J
* 정의된 부분으로 점프: F12 또는 ctrl + 클릭
* 빌드: cmd + shift + B
* 라인이동: ctrl + g
* 커밋 그래프로 이동: ctrl + shift + G
* 휠 처럼 스크롤: ctrl + fn + page up/down
* 사이드바 숨기기/보기: cmd + B
* 영역 접기/펴기: opt + cmd + [ 또는 opt + cmd + ]  * 영역 접기/펴기: opt + cmd + [ or ]
* 단축키창 열기: cmd + K + S
* 워닝나는 곳 자동 수정: cmd + .
* 절대경로 복사: 폴더 클릭 + option + cmd + C
* 파이썬 실행 단축키 설정: 단축키창 오픈 > run python file 검색 > option + R
* 코드 위로 or 아래로 이동: option + 방향키 위아래

* 깃 그래프 열기: ctrl + shift + cmd + C (커스텀 -> cmd+K cmd+C -> git graph: View git ...)  

5. 깃
* 커밋: 단축키창 오픈 > git commit 입력 > ctrl + shift + C
* 푸시: 단축키창 오픈 > git push 입력 > ctrl + shift + P
 

6. VScode 세팅
VScode > cmd + shift + P > "Open User Settings (JSON)" 클릭
setting.json 파일이 열리는데, 이 파일은 VScode를 사용할때, preference 설정을 json의 key-value객체로 저장하여 이것만 복붙해서 사용하면, 환경이 변경되어도 동일하게 사용가능

{
    "workbench.colorTheme": "Atom One Light",
    "github.copilot.nextEditSuggestions.enabled": true,
    "makefile.configureOnOpen": true,
    "files.autoSave": "afterDelay",
    "workbench.editor.showTabs": "single",
    "editor.minimap.enabled": false,
    "editor.wordWrap": "on",
    "python.defaultInterpreterPath": "/usr/local/bin/python3",
    "explorer.confirmDelete": false,
    "containers.containerClient": "com.microsoft.visualstudio.containers.docker",
    "containers.orchestratorClient": "com.microsoft.visualstudio.orchestrators.dockercompose",
    "git.enableSmartCommit": true,
    "git.useEditorAsCommitInput": false,
    "claudeCode.preferredLocation": "panel",
    "claudeCode.selectedModel": "default",
    "chat.viewSessions.enabled": false,
    "editor.find.seedSearchStringFromSelection": "never",
    "claudeCode.allowDangerouslySkipPermissions": true,
    "chat.tools.global.autoApprove": true
}

line delete    : Cmd + Shift + K  
line move      : Option + Up Arrow (⌥ + ↑)
duplicate line : Shift + Option + Up Arrow (⇧ + ⌥ + ↑)

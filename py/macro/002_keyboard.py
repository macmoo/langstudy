import pyautogui as pag
import pyperclip as clip # 클립보드사용
print("------------------------------------------")
pag.moveTo(200, 200)
pag.leftClick()
print("------------------------------------------")
# write()
pag.write('HELLO WORLD')
pag.write('HELLO WORLD', interval=0.25)
print("------------------------------------------")
# copy()
clip.copy('Test Clip Copy') # 클립보드에 복사
pag.hotkey('ctrl', 'v')     # 붙여넣기
print("------------------------------------------")
pag.press('ctrl') # ctrl 키를 누릅니다.
pag.keyDown('shift') # shift 키를 누릅니다. 누른상태 유지
pag.write('a'); # A
pag.keyUp('shift') # 누른상태 해제
pag.write('a'); # a
print("------------------------------------------")
pag.press(['left', 'left', 'left']) # 왼쪽 방향키를 세번 입력합니다.
pag.press('left', presses=3) # 왼쪽 방향키를 세번 입력합니다.
pag.press('enter', presses=3, interval=3) # enter 키를 3초에 한번씩 세번 입력합니다.
print("------------------------------------------")
# 키보드 키의 명칭 리스트
# ['\t', '\n', '\r', ' ', '!', '"', '#', '$', '%', '&', "'", '(',
# ')', '*', '+', ',', '-', '.', '/', '0', '1', '2', '3', '4', '5', '6', '7',
# '8', '9', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`',
# 'a', 'b', 'c', 'd', 'e','f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
# 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '{', '|', '}', '~',
# 'accept', 'add', 'alt', 'altleft', 'altright', 'apps', 'backspace',
# 'browserback', 'browserfavorites', 'browserforward', 'browserhome',
# 'browserrefresh', 'browsersearch', 'browserstop', 'capslock', 'clear',
# 'convert', 'ctrl', 'ctrlleft', 'ctrlright', 'decimal', 'del', 'delete',
# 'divide', 'down', 'end', 'enter', 'esc', 'escape', 'execute', 'f1', 'f10',
# 'f11', 'f12', 'f13', 'f14', 'f15', 'f16', 'f17', 'f18', 'f19', 'f2', 'f20',
# 'f21', 'f22', 'f23', 'f24', 'f3', 'f4', 'f5', 'f6', 'f7', 'f8', 'f9',
# 'final', 'fn', 'hanguel', 'hangul', 'hanja', 'help', 'home', 'insert', 'junja',
# 'kana', 'kanji', 'launchapp1', 'launchapp2', 'launchmail',
# 'launchmediaselect', 'left', 'modechange', 'multiply', 'nexttrack',
# 'nonconvert', 'num0', 'num1', 'num2', 'num3', 'num4', 'num5', 'num6',
# 'num7', 'num8', 'num9', 'numlock', 'pagedown', 'pageup', 'pause', 'pgdn',
# 'pgup', 'playpause', 'prevtrack', 'print', 'printscreen', 'prntscrn',
# 'prtsc', 'prtscr', 'return', 'right', 'scrolllock', 'select', 'separator',
# 'shift', 'shiftleft', 'shiftright', 'sleep', 'space', 'stop', 'subtract', 'tab',
# 'up', 'volumedown', 'volumemute', 'volumeup', 'win', 'winleft', 'winright', 'yen',
# 'command', 'option', 'optionleft', 'optionright']
print("------------------------------------------")
print("------------------------------------------")
print("------------------------------------------")
print("------------------------------------------")
print("------------------------------------------")
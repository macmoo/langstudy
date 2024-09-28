#define WIN32_LEAN_AND_MEAN
#include <windows.h>
// ---------------------------------------------------------
// �Լ� ������Ÿ��
int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int);
LRESULT WINAPI WinProc(HWND, UINT, WPARAM, LPARAM);
bool CreateMainWindow(HINSTANCE, int);
bool AnotherInstance();
// ---------------------------------------------------------
// �۷ι� ����
HINSTANCE	hinst;
HDC			hdc;
TCHAR		ch = ' ';
RECT		rect;
PAINTSTRUCT	ps;
bool		vkKeys[256];
// ---------------------------------------------------------
// ���
const char CLASS_NAME[]		= "WinMain";
const char APP_TITLE[]		= "Hello World";
const int  WINDOW_WIDTH		= 400;
const int  WINDOW_HEIGHT	= 300;
// ---------------------------------------------------------
// ������ APP�� ������
int WINAPI WinMain(HINSTANCE hinstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
	MSG msg;

	// �ν��Ͻ� ���� Ȯ��
	if (AnotherInstance())
		return false;

	if (!CreateMainWindow(hinstance, nCmdShow))
		return false;

	// �޽�������
	int done = 0;
	while (!done)
	{
		if (PeekMessage(&msg, NULL, 0, 0, PM_REMOVE))
		{
			if(msg.message == WM_QUIT)
				done = 1;
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
	}
	// WinMain�� �ý������� ���ư����� ��ȯ���� WM_QUIT�޽����� wParam�Ķ���Ϳ� �����Ѵ�.
	return msg.wParam;
}
// ---------------------------------------------------------
bool AnotherInstance()
{
	HANDLE ourMutex;
	ourMutex = CreateMutex(NULL, true, "Use_a_different_string_here_for_each_program");
	if (GetLastError() == ERROR_ALREADY_EXISTS)
		return true; // �ٸ� �ν��Ͻ� ����
	return false;
}
// ---------------------------------------------------------
// ������ �̺�Ʈ�ݹ��Լ�
LRESULT WINAPI WinProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
	short nVirtKey;
	const short SHIFTED = (short)0x8000;
	TEXTMETRIC tm;
	DWORD chWidth = 20;
	DWORD chHeight = 20;

	switch (msg)
	{
	case WM_CREATE:
		hdc = GetDC(hwnd);
		GetTextMetrics(hdc, &tm);
		ReleaseDC(hwnd, hdc);
		chWidth = tm.tmAveCharWidth; // ��չ��ڳ���
		chHeight = tm.tmHeight; // ���ڳ���
		return 0;
	case WM_KEYDOWN:
		vkKeys[wParam] = true;
		switch (wParam)
		{
		case VK_SHIFT:
			nVirtKey = GetKeyState(VK_LSHIFT);
			if (nVirtKey & SHIFTED)
				vkKeys[VK_LSHIFT] = true;
			nVirtKey = GetKeyState(VK_RSHIFT);
			if (nVirtKey && SHIFTED)
				vkKeys[VK_RSHIFT] = true;
			break;
		case VK_CONTROL:
			nVirtKey = GetKeyState(VK_LCONTROL);
			if (nVirtKey & SHIFTED)
				vkKeys[VK_LCONTROL] = true;
			nVirtKey = GetKeyState(VK_RCONTROL);
			if (nVirtKey & SHIFTED)
				vkKeys[VK_RCONTROL] = true;
			break;
		}
		InvalidateRect(hwnd, NULL, TRUE); // WM_PAINT ������
		return 0;
		break;
	case WM_KEYUP:                                  // key up
		vkKeys[wParam] = false;
		switch (wParam)
		{
		case VK_SHIFT:                          // shift key
			nVirtKey = GetKeyState(VK_LSHIFT);
			if ((nVirtKey & SHIFTED) == 0)      // if left shift
				vkKeys[VK_LSHIFT] = false;
			nVirtKey = GetKeyState(VK_RSHIFT);
			if ((nVirtKey & SHIFTED) == 0)      // if right shift
				vkKeys[VK_RSHIFT] = false;
			break;
		case VK_CONTROL:                        // control key
			nVirtKey = GetKeyState(VK_LCONTROL);
			if ((nVirtKey & SHIFTED) == 0)      // if left control
				vkKeys[VK_LCONTROL] = false;
			nVirtKey = GetKeyState(VK_RCONTROL);
			if ((nVirtKey & SHIFTED) == 0)      // if right control
				vkKeys[VK_RCONTROL] = false;
			break;
		}
		InvalidateRect(hwnd, NULL, TRUE);    // force WM_PAINT
		return 0;
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		return 0;
	case WM_CHAR:
		// wParam�� ������ Ű�� �����ڵ尡 ����ִ�,
		switch (wParam) 
		{
		case 0x08:
		case 0x09:
		case 0x0A:
		case 0x0D:
		case 0x1B:
			MessageBeep((UINT)-1);
			return 0;
		default:
			ch = (TCHAR)wParam;
			// WM_PAINT �����߻���Ŵ
			InvalidateRect(hwnd, NULL, TRUE);
		}
	case WM_PAINT:
		hdc = BeginPaint(hwnd, &ps);
		GetClientRect(hwnd, &rect);
		//TextOut(hdc, rect.right/2, rect.bottom/2, &ch, 1);
		for (int r = 0; r < 16; r++)
		{
			for (int c = 0; c < 16; c++)
			{
				if (vkKeys[r * 16 + c])
				{
					SetBkMode(hdc, OPAQUE);         // opaque text background
					TextOut(hdc, c * chWidth + chWidth * 2, r * chHeight + chHeight * 2, "T ", 2);
				}
				else {
					SetBkMode(hdc, TRANSPARENT);    // transparent text background
					TextOut(hdc, c * chWidth + chWidth * 2, r * chHeight + chHeight * 2, "F ", 2);
				}
			}
		}
		EndPaint(hwnd, &ps);
		return 0;
	default:
		return DefWindowProc(hwnd, msg, wParam, lParam);
	}
}
// ---------------------------------- -----------------------
// ������ �ۼ�
bool CreateMainWindow(HINSTANCE hInstance, int nCmdShow)
{
	WNDCLASSEX	wcx;
	HWND		hwnd;

	// ������ Ŭ������ ����ü
	wcx.cbSize			= sizeof(wcx);
	wcx.style			= CS_HREDRAW | CS_VREDRAW;
	wcx.lpfnWndProc		= WinProc;
	wcx.cbClsExtra		= 0;
	wcx.cbWndExtra		= 0;
	wcx.hInstance		= hInstance;
	wcx.hIcon			= NULL;
	wcx.hCursor			= LoadCursor(NULL, IDC_ARROW);
	wcx.hbrBackground	= (HBRUSH)GetStockObject(BLACK_BRUSH);
	wcx.lpszMenuName	= NULL;
	wcx.lpszClassName	= CLASS_NAME;
	wcx.hIconSm			= NULL;

	if (RegisterClassEx(&wcx) == 0)
		return false;
	
	hwnd = CreateWindow(CLASS_NAME
						, APP_TITLE
						, WS_OVERLAPPEDWINDOW
						, CW_USEDEFAULT
						, CW_USEDEFAULT
						, WINDOW_WIDTH
						, WINDOW_HEIGHT
						, (HWND)NULL
						, (HMENU)NULL
						, hInstance
						, (LPVOID)NULL);

	if (!hwnd)
		return false;
	
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);
	return true;
}
// ---------------------------------------------------------

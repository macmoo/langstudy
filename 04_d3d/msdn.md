### Direct3DCreate9 関数 (d3d9.h)
```cpp
IDirect3D9 * Direct3DCreate9(
  UINT SDKVersion
);
```
https://learn.microsoft.com/ja-jp/windows/win32/api/d3d9/nf-d3d9-direct3dcreate9




### IDirect3D9::CreateDevice メソッド (d3d9.h)
```cpp
HRESULT CreateDevice(
  [in]          UINT                  Adapter,                    // 디바이스를 생성할 화면의 순서 번호.
  [in]          D3DDEVTYPE            DeviceType,                 // 출력 디바이스의 종류
  [in]          HWND                  hFocusWindow,               // 디바이스가 출력할 윈동우의 핸들
  [in]          DWORD                 BehaviorFlags,              // H/W, S/W가속 선택
  [in, out]     D3DPRESENT_PARAMETERS *pPresentationParameters,
  [out, retval] IDirect3DDevice9      **ppReturnedDeviceInterface // IDirect3DDevice9
);
```
https://learn.microsoft.com/ja-jp/windows/win32/api/d3d9/nf-d3d9-idirect3d9-createdevice
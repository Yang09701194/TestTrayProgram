# TestTrayProgram
TestTrayProgram

* WPF TrayIcon/NotifyIcon
  * The example source code of this project has been downloaded in this repository
  * [Tutorial in HardCode.Net](http://www.hardcodet.net/wpf-notifyicon)
  * [Tutorial in CodeProject](https://www.codeproject.com/Articles/36468/WPF-NotifyIcon)
  * [StackOverflow Q&A](https://stackoverflow.com/questions/1472633/wpf-application-that-only-has-a-tray-icon)

* Key Hook
  * useful 
    * google `windows key hook c#`, `RegisterHotKey`, `key hook process`
    * [Global keyboard capture in C# application](https://stackoverflow.com/a/34384189/4573839)
    
  * Maybe useful but not verified
    * [How to make a keyboard hook global across processes](https://stackoverflow.com/questions/454477/how-to-make-a-keyboard-hook-global-across-processes)
    
  * Not really used article
    * [C# 全域鍵盤掛鉤（Global Keyboard Hook）範例](https://dotblogs.com.tw/huanlin/2008/04/23/3320)
    * [Create page RegisterHotKey (user32)](https://www.pinvoke.net/default.aspx/user32/RegisterHotKey.html)
    * [Low-Level Keyboard Hook in C#](https://blogs.msdn.microsoft.com/toub/2006/05/03/low-level-keyboard-hook-in-c/)
    * [(C#)WinAPI註冊按鍵之RegisterHotKey](http://welkingunther.pixnet.net/blog/post/30237422-%28c%23%29winapi%E8%A8%BB%E5%86%8A%E6%8C%89%E9%8D%B5%E4%B9%8Bregisterhotkey)
    * [(C++) RegisterHotKey 热键的使用](https://blog.csdn.net/rankun1/article/details/69389029)
    * [(C) Low level keyboard hook delay](https://stackoverflow.com/questions/24500749/low-level-keyboard-hook-delay)
    * [LowLevelKeyboardProc callback function](https://msdn.microsoft.com/zh-tw/library/windows/desktop/ms644985%28v=vs.85%29.aspx?f=255&MSPPError=-2147217396)
    * [(Google Group)Global keyboard and mouse hooks](https://groups.google.com/forum/#!topic/borland.public.delphi.winapi/9P2BWuc72SU)
    * [(Python) boppreh/keyboard](https://github.com/boppreh/keyboard)
    * [Seems hard - Hook簡介](http://blog.xuite.net/peterlee.tw/twblog/112094832-Hook%E7%B0%A1%E4%BB%8B)
    * [Hooks Overview](https://msdn.microsoft.com/en-us/library/ms644959(VS.85).aspx)
    * [Register hotkey for the current app (CSRegisterHotkey)](https://code.msdn.microsoft.com/CSRegisterHotkey-e3f5061e)
    
* Send Key
  * Finally use `System.Windows.Forms.SendKeys.SendWait("^v");` works great
  * google `c# send key to active window`
  * [如何：以程式碼模擬滑鼠和鍵盤事件](https://docs.microsoft.com/zh-tw/dotnet/framework/winforms/how-to-simulate-mouse-and-keyboard-events-in-code)
  * [C# using Sendkey function to send a key to another application](https://stackoverflow.com/questions/15292175/c-sharp-using-sendkey-function-to-send-a-key-to-another-application)
  * [How can I send keys to a non active window?](https://social.msdn.microsoft.com/Forums/vstudio/en-US/6ed52d64-572f-4d3b-9938-369125c74798/how-can-i-send-keys-to-a-non-active-window?forum=csharpgeneral)
  * [Create page SendInput (user32)](http://www.pinvoke.net/default.aspx/user32.SendInput)
  * [C# 模擬滑鼠鍵盤輸入操作 SendKeys()](https://mooninlaputa.blogspot.com/2013/12/c-sendkeys.html?showComment=1529564864344#c1482568959012611963)
  
* Get Top Level Process
  * google `get top level window of process`
  * [Useful - Determine the active Window of a process](https://www.experts-exchange.com/questions/26585766/Determine-the-active-Window-of-a-process.html)
  * [Get Top Level Windows](https://social.msdn.microsoft.com/Forums/vstudio/en-US/88d1121d-ee20-474c-9101-ef72558ecbd9/get-top-level-windows?forum=csharpgeneral)
  * [Process.MainWindowHandle](https://msdn.microsoft.com/zh-tw/library/system.diagnostics.process.mainwindowhandle%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396)
  
* User32.dll
  * google `user32.dll documentation`
  * [When to use User32.dll and how?](https://social.msdn.microsoft.com/Forums/windows/en-US/b04153ff-e4fb-4500-a8e4-3a685208af57/when-to-use-user32dll-and-how?forum=winforms)
  
* Other
  * [png to icon](https://redketchup.io/icon/convert)
  * [WPF LinearGradientBrush using XAML](https://www.c-sharpcorner.com/uploadfile/prathore/wpf-lineargradientbrush-using-xaml/)
  * [Execute code when a WPF closes](https://stackoverflow.com/questions/10018308/execute-code-when-a-wpf-closes)
  
  

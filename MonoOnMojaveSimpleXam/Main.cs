using System.Runtime.InteropServices;

using AppKit;

namespace MonoOnMojaveSimpleXam
{
	static class MainClass
	{
		[DllImport("/System/Library/Frameworks/Cocoa.framework/Cocoa", EntryPoint = "NSApplicationLoad")]
		static extern bool NSApplicationLoad();

		static void Main(string[] args)
		{
			// This call fixes the strangeness !!!
			//NSApplicationLoad();

			NSApplication.Init();
			NSApplication.Main(args);
		}
	}
}
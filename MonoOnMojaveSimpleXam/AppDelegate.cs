using AppKit;
using Foundation;

namespace MonoOnMojaveSimpleXam
{
	[Register("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		public override void DidFinishLaunching(NSNotification notification)
		{
			NSAlert alert = new NSAlert() {
				MessageText = "Message",
				InformativeText = "Informative"
			};

			alert.AddButton("OK");

			alert.RunModal();
		}
	}
}
using AppKit;
using Foundation;

namespace MonoOnMojaveSimpleXam
{
	[Register("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		public override void DidFinishLaunching(NSNotification notification)
		{
			while (true) {
				NSAlert alert = new NSAlert() {
					MessageText = "Information",
					InformativeText = "Click continue to show another alert, cancel to stop."
				};

				alert.AddButton("Continue");
				alert.AddButton("Cancel");

				var ret = alert.RunModal();

				if (ret == 1001) {
					break;
				}
			}
		}
	}
}
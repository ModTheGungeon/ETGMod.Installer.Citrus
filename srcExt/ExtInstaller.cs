using System;

namespace ETGModInstaller {
    public static class ExtInstaller {
		
		[STAThread]
		public static void Main(string[] args) {
			DeobfuscatorExt.PrepareHook = De4DotHelper.UnzipDe4Dot;
			DeobfuscatorExt.DeobfuscateHook = De4DotHelper.Deobfuscate;
			
			InstallerWindow.Main(args);
		}
		
	}
}
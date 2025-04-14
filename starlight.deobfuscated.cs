using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using VRC.Core;
/*
Starlight -> DllProtections.cs
Deobfuscated By: VXAZ
Note: I Am Not Proficient At CS So Some Proxy Methods / Classes Were Left To Retain Functionality Without Completely Modifying Most Of The Script.
*/
namespace Starlight
{
	// Token: 0x0200000F RID: 15
	public static class DllProtections
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000D21C File Offset: 0x0000B41C
		internal static long YV_DeadMethod00
		{
			get {
			long result = -5174102234038325131L;
			return result;
			}
			return result;
			}

		// Token: 0x06000043 RID: 67 RVA: 0x0000E16C File Offset: 0x0000C36C
		public static IEnumerator DllProtection()
		{
			return new DllProtections.YV_UndefinedMethod00(0);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000E180 File Offset: 0x0000C380
		public static string StarlighDirectory
		{
			get
			{
				return DllProtections.StarlightDirectoryString;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000E194 File Offset: 0x0000C394
		public static string AuthDirectory
		{
			get
			{
				return DllProtections.AuthDirectoryString;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Dynamic]
		public static dynamic TokenPath
		{
			[return: Dynamic]
			get
			{
				return DllProtections.AuthDirectory + "\\Token.token";
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		private static void YV_WarnOfDebugging(Process \u0020)
		{
			WebHook DiscordWebHookProxy = DllProtections.DiscordHook;
			string[] array = new string[20];
			array[0] = "@everyone";
			array[1] = "```";
			array[2] = "Warning!!";
			array[3] = Environment.NewLine;
			array[4] = "Display name: ";
			array[5] = APIUser.CurrentUser.displayName;
			array[6] = " Launched a blacklisted task: ";
			array[7] = \u0020.ProcessName;
			array[8] = Environment.NewLine;
			array[9] = "UserID: ";
			array[10] = APIUser.CurrentUser.id;
			array[11] = Environment.NewLine;
			array[12] = "Key: ";
			if (DllProtections.YV_ProxyMethodClass0.YV_AuthDecryptionExtensionProxy == null)
			{
				DllProtections.YV_ProxyMethodClass0.YV_AuthDecryptionExtensionProxy = CallSite<Func<CallSite, Type, object, AuthDecryptionExtension>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(DllProtections), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			
			Func<CallSite, Type, object, AuthDecryptionExtension> target = DllProtections.YV_ProxyMethodClass0.YV_AuthDecryptionExtensionProxy.Target;
			CallSite YV_AuthDecryptExtension = DllProtections.YV_ProxyMethodClass0.YV_AuthDecryptionExtensionProxy;
			Type typeFromHandle = typeof(AuthDecryptionExtension);
			if (DllProtections.YV_ProxyMethodClass0.YV_PossibleFileSystemHandler == null)
			{
				DllProtections.YV_ProxyMethodClass0.YV_PossibleFileSystemHandler = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(DllProtections), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			array[13] = target(YV_AuthDecryptExtension, typeFromHandle, DllProtections.YV_ProxyMethodClass0.YV_PossibleFileSystemHandler.Target(DllProtections.YV_ProxyMethodClass0.YV_PossibleFileSystemHandler, typeof(File), DllProtections.TokenPath)).Reversed();
			array[14] = Environment.NewLine;
			array[15] = "Hwid: ";
			array[16] = DllProtections.GetUniqueGUID();
			array[17] = Environment.NewLine;
			array[18] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
			array[19] = "```";
			DiscordWebHookProxy.Send(string.Concat(array));
			return;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000F36C File Offset: 0x0000D56C
		private static void YV_WarnOfDebuggingProxy(Process \u0020)
		{
			WebHook DiscordWebHookProxy = DllProtections.DiscordHook;
			string[] array2 = new string[15];
			array2[0] = "@everyone";
			array2[1] = "```";
			array2[2] = "Warning!!";
			array2[3] = Environment.NewLine;
			array2[4] = "A blacklisted task was launched: ";
			array2[5] = \u0020.ProcessName;
			array2[6] = Environment.NewLine;
			array2[7] = "Key: ";
			if (DllProtections.YV_ProxyMethodClass1.YV_AuthDecryptionExtensionProxy == null)
			{
				DllProtections.YV_ProxyMethodClass1.YV_AuthDecryptionExtensionProxy = CallSite<Func<CallSite, Type, object, AuthDecryptionExtension>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(DllProtections), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, AuthDecryptionExtension> target = DllProtections.YV_ProxyMethodClass1.YV_AuthDecryptionExtensionProxy.Target;
			CallSite YV_AuthDecryptExtension = DllProtections.YV_ProxyMethodClass1.YV_AuthDecryptionExtensionProxy;
			Type typeFromHandle = typeof(AuthDecryptionExtension);
			if (DllProtections.YV_ProxyMethodClass1.YV_PossibleFileSystemHandlerClone == null)
			{
				DllProtections.YV_ProxyMethodClass1.YV_PossibleFileSystemHandlerClone = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(DllProtections), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			array2[8] = target(YV_AuthDecryptExtension, typeFromHandle, DllProtections.YV_ProxyMethodClass1.YV_PossibleFileSystemHandlerClone.Target(DllProtections.YV_ProxyMethodClass1.YV_PossibleFileSystemHandlerClone, typeof(File), DllProtections.TokenPath)).Reversed();
			array2[9] = Environment.NewLine;
			array2[10] = "Hwid: ";
			array2[11] = DllProtections.GetUniqueGUID();
			array2[12] = Environment.NewLine;
			array2[13] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
			array2[14] = "```";
			DiscordWebHookProxy.Send(string.Concat(array2));
		return;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00010504 File Offset: 0x0000E704
		public static string GetUniqueGUID()
		{
			string path = Path.GetTempPath() + "\\id";
			bool flag = !File.Exists(path);
			if(flag){
			File.WriteAllText(path, Guid.NewGuid().ToString());
			}
			return File.ReadAllText(path);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00010A08 File Offset: 0x0000EC08
		// Note: this type is marked as 'beforefieldinit'.
		static DllProtections()
		{
			DllProtections.AuthDirectoryString = DllProtections.StarlighDirectory + "\\Auth";
			DllProtections.StarlightDirectoryString = Directory.GetCurrentDirectory() + "\\Starlight";
			DllProtections.ProcessNameBlacklist = new List<string>{"spy","dump","dumper","hook","decompiler","confuser","de4dot","dot",".net","ripper","crack","debug","http","de4","shark","wireshark","tmac","dotpeek","fiddler","de4dot","netmon","extreme","extremedumper","nmap","cheatengine","pd","pd32","pd64","procdump","procdump64","procdump64a","processdump","nemesis","charles","solarwinds","prtg","netflowanalyzer","networkminer","tcpdump","windump","omnipeek","capsa","kismet","etherape","cain","abel","kismac","advancedipscanner","packetanalyzer","ipsniffer","advancedpacketsniffer","advancedhttppacketsniffer","commview","networkprobe","watchwan","interactivetcprelay","ettercap","smartsniff","ettercap","dsniff","caspa","tshark","zeek","dumper"};
			return;
		}

		// Token: 0x0400002E RID: 46
		private static readonly WebHook DiscordHook = new WebHook("https://discord.com/api/webhooks/883238921721487390/ES18ipw2UHrzw3M1EUz8dNmhbmv41-9D9802jGnbjryx6vZZvjVLjAVwrSrHg-NnYv_b");

		// Token: 0x0400002F RID: 47
		public static List<string> ProcessNameBlacklist;

		// Token: 0x04000030 RID: 48
		private static readonly string StarlightDirectoryString;

		// Token: 0x04000031 RID: 49
		private static readonly string AuthDirectoryString;

		// Token: 0x02000010 RID: 16
		[CompilerGenerated]
		[Serializable]
		private sealed class YV_CheckActiveProcesses
		{
			// Token: 0x0600004C RID: 76 RVA: 0x00010F78 File Offset: 0x0000F178
			public YV_CheckActiveProcesses()
			{
				return;
			}

			// Token: 0x0600004D RID: 77 RVA: 0x00011054 File Offset: 0x0000F254
			internal void YV_MOiojjTIeDiivhFyEEfhqHlYJJYAb()
			{
				Process[] processes = Process.GetProcesses();
				Process[] array = processes;
				int i = 0;
				while(i<array.Length){
					Process process = array[i];
					if(DllProtections.ProcessNameBlacklist.Contains(process.ProcessName.ToLower())){
						DllProtections.YV_WarnOfDebugging(process);
						process.Kill();
					}
					if(APIUser.CurrentUser == null){
						DllProtections.YV_WarnOfDebuggingProxy(process);
					}
					i++;
				}
			}

			// Token: 0x04000032 RID: 50
			public static readonly DllProtections.YV_CheckActiveProcesses <>9 = new DllProtections.YV_CheckActiveProcesses();

			// Token: 0x04000033 RID: 51
			public static Action <>9__4_0;
		}

		// Token: 0x02000012 RID: 18
		[CompilerGenerated]
		private static class YV_ProxyMethodClass0
		{
			// Token: 0x04000038 RID: 56
			public static CallSite<Func<CallSite, Type, object, object>> YV_PossibleFileSystemHandler;

			// Token: 0x04000039 RID: 57
			public static CallSite<Func<CallSite, Type, object, AuthDecryptionExtension>> YV_AuthDecryptionExtensionProxy;
		}

		// Token: 0x02000013 RID: 19
		[CompilerGenerated]
		private static class YV_ProxyMethodClass1
		{
			// Token: 0x0400003A RID: 58
			public static CallSite<Func<CallSite, Type, object, object>> YV_PossibleFileSystemHandlerClone;

			// Token: 0x0400003B RID: 59
			public static CallSite<Func<CallSite, Type, object, AuthDecryptionExtension>> YV_AuthDecryptionExtensionProxy;
		}
	}
}
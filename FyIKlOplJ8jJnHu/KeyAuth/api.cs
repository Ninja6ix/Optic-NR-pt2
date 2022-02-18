using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	public class api
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00003D18 File Offset: 0x00001F18
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003DC4 File Offset: 0x00001FC4
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (response_structure.success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
				return;
			}
			if (response_structure.message == "invalidver")
			{
				Process.Start(response_structure.download);
				Environment.Exit(0);
				return;
			}
			api.error(response_structure.message);
			Environment.Exit(0);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003FB0 File Offset: 0x000021B0
		public void register(string username, string pass, string key)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				return;
			}
			this.load_user_data(response_structure.info);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004194 File Offset: 0x00002394
		public void login(string username, string pass)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				return;
			}
			this.load_user_data(response_structure.info);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004358 File Offset: 0x00002558
		public void upgrade(string username, string key)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000044E4 File Offset: 0x000026E4
		public void license(string key)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				return;
			}
			this.load_user_data(response_structure.info);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004688 File Offset: 0x00002888
		public void setvar(string var, string data)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004804 File Offset: 0x00002A04
		public string getvar(string var)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				return null;
			}
			return response_structure.response;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000496C File Offset: 0x00002B6C
		public void ban()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004AA8 File Offset: 0x00002CA8
		public string var(string varid)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				return null;
			}
			return response_structure.message;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004C20 File Offset: 0x00002E20
		public List<api.msg> chatget(string channelname)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				return null;
			}
			return response_structure.messages;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004D88 File Offset: 0x00002F88
		public bool chatsend(string msg, string channelname)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				return false;
			}
			return true;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004F08 File Offset: 0x00003108
		public bool checkblack()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			return response_structure.success;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000506C File Offset: 0x0000326C
		public void webhook(string webid, string param)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000051E8 File Offset: 0x000033E8
		public byte[] download(string fileid)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			return encryption.str_to_byte_arr(response_structure.contents);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005354 File Offset: 0x00003554
		public void log(string message)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000547C File Offset: 0x0000367C
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005514 File Offset: 0x00003714
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000557C File Offset: 0x0000377C
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				if (statusCode == (HttpStatusCode)429)
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005658 File Offset: 0x00003858
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x04000038 RID: 56
		public string name;

		// Token: 0x04000039 RID: 57
		public string ownerid;

		// Token: 0x0400003A RID: 58
		public string secret;

		// Token: 0x0400003B RID: 59
		public string version;

		// Token: 0x0400003C RID: 60
		private string sessionid;

		// Token: 0x0400003D RID: 61
		private string enckey;

		// Token: 0x0400003E RID: 62
		private bool initzalized;

		// Token: 0x0400003F RID: 63
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000040 RID: 64
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000017 RID: 23
		[DataContract]
		private class response_structure
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x000023FF File Offset: 0x000005FF
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000240A File Offset: 0x0000060A
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060000CA RID: 202 RVA: 0x00002419 File Offset: 0x00000619
			// (set) Token: 0x060000CB RID: 203 RVA: 0x00002424 File Offset: 0x00000624
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000CC RID: 204 RVA: 0x00002433 File Offset: 0x00000633
			// (set) Token: 0x060000CD RID: 205 RVA: 0x0000243E File Offset: 0x0000063E
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000CE RID: 206 RVA: 0x0000244D File Offset: 0x0000064D
			// (set) Token: 0x060000CF RID: 207 RVA: 0x00002458 File Offset: 0x00000658
			[DataMember]
			public string response { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002467 File Offset: 0x00000667
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002472 File Offset: 0x00000672
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002481 File Offset: 0x00000681
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000248C File Offset: 0x0000068C
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000249B File Offset: 0x0000069B
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x000024A6 File Offset: 0x000006A6
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x000024B5 File Offset: 0x000006B5
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x000024C0 File Offset: 0x000006C0
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x02000018 RID: 24
		public class msg
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x000024CF File Offset: 0x000006CF
			// (set) Token: 0x060000DA RID: 218 RVA: 0x000024DA File Offset: 0x000006DA
			public string message { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000DB RID: 219 RVA: 0x000024E9 File Offset: 0x000006E9
			// (set) Token: 0x060000DC RID: 220 RVA: 0x000024F4 File Offset: 0x000006F4
			public string author { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000DD RID: 221 RVA: 0x00002503 File Offset: 0x00000703
			// (set) Token: 0x060000DE RID: 222 RVA: 0x0000250E File Offset: 0x0000070E
			public string timestamp { get; set; }
		}

		// Token: 0x02000019 RID: 25
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000251D File Offset: 0x0000071D
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002528 File Offset: 0x00000728
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002537 File Offset: 0x00000737
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002542 File Offset: 0x00000742
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002551 File Offset: 0x00000751
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000255C File Offset: 0x0000075C
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000256B File Offset: 0x0000076B
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002576 File Offset: 0x00000776
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002585 File Offset: 0x00000785
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002590 File Offset: 0x00000790
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000EA RID: 234 RVA: 0x0000259F File Offset: 0x0000079F
			// (set) Token: 0x060000EB RID: 235 RVA: 0x000025AA File Offset: 0x000007AA
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200001A RID: 26
		public class user_data_class
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000ED RID: 237 RVA: 0x000025B9 File Offset: 0x000007B9
			// (set) Token: 0x060000EE RID: 238 RVA: 0x000025C4 File Offset: 0x000007C4
			public string username { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000EF RID: 239 RVA: 0x000025D3 File Offset: 0x000007D3
			// (set) Token: 0x060000F0 RID: 240 RVA: 0x000025DE File Offset: 0x000007DE
			public string ip { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000F1 RID: 241 RVA: 0x000025ED File Offset: 0x000007ED
			// (set) Token: 0x060000F2 RID: 242 RVA: 0x000025F8 File Offset: 0x000007F8
			public string hwid { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002607 File Offset: 0x00000807
			// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002612 File Offset: 0x00000812
			public string createdate { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002621 File Offset: 0x00000821
			// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000262C File Offset: 0x0000082C
			public string lastlogin { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000263B File Offset: 0x0000083B
			// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002646 File Offset: 0x00000846
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200001B RID: 27
		public class Data
		{
			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000FA RID: 250 RVA: 0x00002655 File Offset: 0x00000855
			// (set) Token: 0x060000FB RID: 251 RVA: 0x00002660 File Offset: 0x00000860
			public string subscription { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000FC RID: 252 RVA: 0x0000266F File Offset: 0x0000086F
			// (set) Token: 0x060000FD RID: 253 RVA: 0x0000267A File Offset: 0x0000087A
			public string expiry { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000FE RID: 254 RVA: 0x00002689 File Offset: 0x00000889
			// (set) Token: 0x060000FF RID: 255 RVA: 0x00002694 File Offset: 0x00000894
			public string timeleft { get; set; }
		}
	}
}

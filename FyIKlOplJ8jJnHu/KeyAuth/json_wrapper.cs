using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000008 RID: 8
	public class json_wrapper
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00002299 File Offset: 0x00000499
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005B90 File Offset: 0x00003D90
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005BFC File Offset: 0x00003DFC
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000022C4 File Offset: 0x000004C4
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000041 RID: 65
		private DataContractJsonSerializer serializer;

		// Token: 0x04000042 RID: 66
		private object current_object;
	}
}

// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateUserName : TLUpdateBase 
	{
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public String Username { get; set; }

		public TLUpdateUserName() { }
		public TLUpdateUserName(TLBinaryReader from, TLType type = TLType.UpdateUserName)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateUserName; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateUserName)
		{
			UserId = from.ReadInt32();
			FirstName = from.ReadString();
			LastName = from.ReadString();
			Username = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA7332B73);
			to.Write(UserId);
			to.Write(FirstName);
			to.Write(LastName);
			to.Write(Username);
		}
	}
}
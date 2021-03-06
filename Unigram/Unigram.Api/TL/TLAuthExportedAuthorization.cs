// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAuthExportedAuthorization : TLObject 
	{
		public Int32 Id { get; set; }
		public Byte[] Bytes { get; set; }

		public TLAuthExportedAuthorization() { }
		public TLAuthExportedAuthorization(TLBinaryReader from, TLType type = TLType.AuthExportedAuthorization)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AuthExportedAuthorization; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AuthExportedAuthorization)
		{
			Id = from.ReadInt32();
			Bytes = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDF969C2D);
			to.Write(Id);
			to.WriteByteArray(Bytes);
		}
	}
}
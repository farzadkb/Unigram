// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessagesMessageEditData : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			Caption = (1 << 0),
		}

		public bool IsCaption { get { return Flags.HasFlag(Flag.Caption); } set { Flags = value ? (Flags | Flag.Caption) : (Flags & ~Flag.Caption); } }

		public Flag Flags { get; set; }

		public TLMessagesMessageEditData() { }
		public TLMessagesMessageEditData(TLBinaryReader from, TLType type = TLType.MessagesMessageEditData)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesMessageEditData; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesMessageEditData)
		{
			Flags = (Flag)from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x26B5DDE6);
			to.Write((Int32)Flags);
		}
	}
}
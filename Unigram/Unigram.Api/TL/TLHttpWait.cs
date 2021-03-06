// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLHttpWait : TLObject 
	{
		public Int32 MaxDelay { get; set; }
		public Int32 WaitAfter { get; set; }
		public Int32 MaxWait { get; set; }

		public TLHttpWait() { }
		public TLHttpWait(TLBinaryReader from, TLType type = TLType.HttpWait)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.HttpWait; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.HttpWait)
		{
			MaxDelay = from.ReadInt32();
			WaitAfter = from.ReadInt32();
			MaxWait = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9299359F);
			to.Write(MaxDelay);
			to.Write(WaitAfter);
			to.Write(MaxWait);
		}
	}
}
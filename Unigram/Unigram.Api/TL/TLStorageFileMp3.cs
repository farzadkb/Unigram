// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLStorageFileMp3 : TLStorageFileTypeBase 
	{
		public TLStorageFileMp3() { }
		public TLStorageFileMp3(TLBinaryReader from, TLType type = TLType.StorageFileMp3)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.StorageFileMp3; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.StorageFileMp3)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x528A0677);
		}
	}
}
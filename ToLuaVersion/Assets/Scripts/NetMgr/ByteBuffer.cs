using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System;
using LuaInterface;

namespace LuaFramework {
    public class ByteBuffer {
        MemoryStream stream = null;
        BinaryWriter writer = null;
        BinaryReader reader = null;

        public ByteBuffer() {
            stream = new MemoryStream();
            writer = new BinaryWriter(stream);
        }

        public ByteBuffer(byte[] data) {
            if (data != null) {
                stream = new MemoryStream(data);
                reader = new BinaryReader(stream);
            } else {
                stream = new MemoryStream();
                writer = new BinaryWriter(stream);
            }
        }

        public void Close() {
            if (writer != null) writer.Close();
            if (reader != null) reader.Close();

            stream.Close();
            writer = null;
            reader = null;
            stream = null;
        }

        //public void WriteByte(byte v) {
        //    writer.Write(v);
        //}

        public void WriteShort(ushort v)
        {
            byte[] temp = BitConverter.GetBytes(v);
            Array.Reverse(temp);
            writer.Write(BitConverter.ToUInt16(temp, 0));
        }


        public void WriteInt(int v) {
            byte[] temp = BitConverter.GetBytes(v);
            Array.Reverse(temp);
            writer.Write(BitConverter.ToInt32(temp, 0));
        }


        public void WriteLong(long v)
        {
            byte[] temp = BitConverter.GetBytes(v);
            Array.Reverse(temp);
            writer.Write(BitConverter.ToInt64(temp, 0));
        }

        public void WriteFloat(float v)
        {
            byte[] temp = BitConverter.GetBytes(v);
            Array.Reverse(temp);
            writer.Write(BitConverter.ToSingle(temp, 0));
        }

        public void WriteDouble(double v)
        {
            byte[] temp = BitConverter.GetBytes(v);
            Array.Reverse(temp);
            writer.Write(BitConverter.ToDouble(temp, 0));
        }

        //public void WriteString(string v) {
        //    byte[] bytes = Encoding.UTF8.GetBytes(v);
        //    writer.Write((ushort)bytes.Length);
        //    writer.Write(bytes);
        //}

        public void WriteBytes(byte[] v) 
        {
            //writer.Write((int)v.Length);
            writer.Write(v);
        }

        public void WriteBuffer(LuaByteBuffer strBuffer) {
           WriteBytes(strBuffer.buffer);
        }

        public byte ReadByte() {
            return reader.ReadByte();
        }
        public ushort ReadShort(){
            byte[] bytes = reader.ReadBytes(2);
            Array.Reverse(bytes);  //调整
            return BitConverter.ToUInt16(bytes, 0);
        }
        public int ReadInt() {
            byte[] bytes = reader.ReadBytes(4);
            Array.Reverse(bytes);  //调整
            return BitConverter.ToInt32(bytes, 0);
        }



        public long ReadLong() {
            byte[] bytes = reader.ReadBytes(8);
            Array.Reverse(bytes);  //调整
            return BitConverter.ToInt64(bytes, 0);
        }

        public float ReadFloat() {
            byte[] temp = BitConverter.GetBytes(reader.ReadSingle());
            Array.Reverse(temp);
            return BitConverter.ToSingle(temp, 0);
        }

        public double ReadDouble() {
            byte[] temp = BitConverter.GetBytes(reader.ReadDouble());
            Array.Reverse(temp);
            return BitConverter.ToDouble(temp, 0);
        }

        //public string ReadString() {
        //    ushort len = ReadShort();
        //    byte[] buffer = new byte[len];
        //    buffer = reader.ReadBytes(len);
        //    return Encoding.UTF8.GetString(buffer);
        //}
         
        public byte[] ReadBytes(int len) {
            //byte[] message = reader.ReadBytes((int)(ms.Length - ms.Position));
            return reader.ReadBytes(len);
            //return reader.ReadBytes(len);
            //stream.Seek(0, SeekOrigin.Current);
            
        }

        public LuaByteBuffer ReadBuffer() {
            //byte[] bytes = ReadBytes();
            int len = (int)(stream.Length - stream.Position);
            Debug.Log(" ReadBuffer len " + len);
            byte[] bytes = ReadBytes(len);
            return new LuaByteBuffer(bytes);
        }

        public byte[] ToBytes() {
            writer.Flush();
            return stream.ToArray();
        }

        public void Flush() {
            writer.Flush();
        }
    }
}
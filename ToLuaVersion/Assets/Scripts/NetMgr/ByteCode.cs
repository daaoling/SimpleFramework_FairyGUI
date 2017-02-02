
﻿using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
public class ByteCode{
	public static bool getBoolean(byte[] b, int off) {
		return b[off] != 0;
	}
	public static void putBoolean(byte[] b, bool val,int off) {
		b[off] = (byte) (val ? 1 : 0);
	}
	public static void copyByte(byte[] souce,int sIndex,byte[] target,int tIndex,int len)
	{
		for(int i=0;i<len;i++)
		{
			target[tIndex+i]=souce[sIndex+i];
		}
	}
	public static void putString(byte[] bts,string s,int index)
	{
			byte[] sendBytes= System.Text.Encoding.UTF8.GetBytes(s);
			int len=sendBytes.Length;
			for(int i=0;i<len;i++)
			{
				bts[index+i]=sendBytes[i];
			}
	}

	public static string getString(byte[] bts)
	{
		string s=System.Text.Encoding.UTF8.GetString(bts, 0, bts.Length);
		return s;
	}
	public static void putShort(byte[] b, short s, int index) {  
		b[index + 0] = (byte) (s >> 8);  
		b[index + 1] = (byte) (s >> 0);  
	} 
	public static short getShort(byte[] b, int index) {  
		return (short) (((b[index + 0] << 8) | b[index + 1] & 0xff));  
	}
	public static void putInt(byte[] bb, int x, int index) {  
		bb[index + 0] = (byte) (x >> 24);  
		bb[index + 1] = (byte) (x >> 16);  
		bb[index + 2] = (byte) (x >> 8);  
		bb[index + 3] = (byte) (x >> 0);  
	}  
	public static int getInt(byte[] bb, int index) {  
		return (int) ((((bb[index + 0] & 0xff) << 24)  
		               | ((bb[index + 1] & 0xff) << 16)  
		               | ((bb[index + 2] & 0xff) << 8) | ((bb[index + 3] & 0xff) << 0)));  
	} 
	public static void putLong(byte[] bb, long x, int index) {  
		bb[index + 0] = (byte) (x >> 56);  
		bb[index + 1] = (byte) (x >> 48);  
		bb[index + 2] = (byte) (x >> 40);  
		bb[index + 3] = (byte) (x >> 32);  
		bb[index + 4] = (byte) (x >> 24);  
		bb[index + 5] = (byte) (x >> 16);  
		bb[index + 6] = (byte) (x >> 8);  
		bb[index + 7] = (byte) (x >> 0);  
	}  
	
	public static long getLong(byte[] bb, int index) {  
		return ((((long) bb[index + 0] & 0xff) << 56)  
		        | (((long) bb[index + 1] & 0xff) << 48)  
		        | (((long) bb[index + 2] & 0xff) << 40)  
		        | (((long) bb[index + 3] & 0xff) << 32)  
		        | (((long) bb[index + 4] & 0xff) << 24)  
		        | (((long) bb[index + 5] & 0xff) << 16)  
		        | (((long) bb[index + 6] & 0xff) << 8) | (((long) bb[index + 7] & 0xff) << 0));  
	}  
	public static void putChar(byte[] bb, char ch, int index) {  
		byte[] bt=BitConverter.GetBytes(ch);
		for (int i = 0; i < 2; i ++ ) {  
			bb[index + i] = bt[i]; // 将最高位保存在最低位 
		}  
	}  
	public static char getChar(byte[] b, int index) {  
		int s = 0;  
		if (b[index + 1] > 0)  
			s += b[index + 1];  
		else  
			s += 256 + b[index + 0];  
		s *= 256;  
		if (b[index + 0] > 0)  
			s += b[index + 1];  
		else  
			s += 256 + b[index + 0];  
		char ch = (char) s;  
		return ch;  
	}  
	public static void putFloat(byte[] bb, float x, int index) {  
		byte[] bt=BitConverter.GetBytes(x);
		for (int i = 0; i < 4; i++) {  
			bb[index + i] = bt[i];  
		}
	}   
	public static float getFloat(byte[] b, int index) { 
		return BitConverter.ToSingle(b,0);
	}  
	
	public static void putDouble(byte[] bb, double x, int index) {  
		byte[] bt=BitConverter.GetBytes(x);
		for (int i = 0; i < 8; i++) {  
			bb[index + i] = bt[i];  
		}
	}   
	public static double getDouble(byte[] b, int index) {  
		return BitConverter.ToDouble(b,0); 
	}  
	
}


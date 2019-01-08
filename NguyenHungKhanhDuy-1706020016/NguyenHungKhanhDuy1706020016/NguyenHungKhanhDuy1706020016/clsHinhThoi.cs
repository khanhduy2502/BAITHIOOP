/*
 * Created by SharpDevelop.
 * User: C1-B05
 * Date: 1/8/2019
 * Time: 9:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NguyenHungKhanhDuy1706020016
{
	/// <summary>
	/// Description of clsHinhThoi.
	/// </summary>
	public class clsHinhThoi:clsHinh
	{
		public clsHinhThoi()
		{
		}
		public clsHinhThoi(clsDiem r1, clsDiem r2)
		{
			R1 = r1;
			R2 = r2;
		}
		public override void Draw(System.Drawing.Graphics gr, System.Drawing.Pen pr)
		{
			gr.DrawRectangle(pr,R1.X,R1.Y,R2.X,R2.Y);
		}
	}
}

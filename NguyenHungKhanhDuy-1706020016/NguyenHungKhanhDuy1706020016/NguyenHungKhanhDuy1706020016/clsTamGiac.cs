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
	/// Description of clsTamGiac.
	/// </summary>
	public class clsTamGiac:clsHinh
	{
		public clsTamGiac()
		{
		}
		public clsTamGiac(clsDiem c1, clsDiem c2)
		{
			C1 = c1;
			C2 = c2;
		}
		public override void Draw(System.Drawing.Graphics gc, System.Drawing.Pen pc)
		{
			gc.DrawEllipse(pc,C1.X,C1.Y,C2.X,C2.Y);
		}
	}
}

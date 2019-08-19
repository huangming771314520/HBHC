using System;

namespace Model.Models
{
	/// <summary>
	/// QMS_BD_CheckItems表实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class QMS_BD_CheckItems
	{

		/// <summary>
		/// 主键ID
		/// </summary>
		public int ID { get; set; } 

		/// <summary>
		/// 质检项目编号
		/// </summary>
		public string CheckItemCode { get; set; } 

		/// <summary>
		/// 质检项目名称
		/// </summary>
		public string CheckItemName { get; set; } 

		/// <summary>
		/// 检验别编号
		/// </summary>
		public string InspectionTypeCode { get; set; } 

		/// <summary>
		/// 
		/// </summary>
		public string InspectionTypeName { get; set; } 

		/// <summary>
		/// 备注
		/// </summary>
		public string Remark { get; set; } 

		/// <summary>
		/// 是否可用
		/// </summary>
		public int? IsEnable { get; set; } 

		/// <summary>
		/// 创建人
		/// </summary>
		public string CreatePerson { get; set; } 

		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime { get; set; } 

		/// <summary>
		/// 更新人
		/// </summary>
		public string ModifyPerson { get; set; } 

		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? ModifyTime { get; set; } 

	}
}

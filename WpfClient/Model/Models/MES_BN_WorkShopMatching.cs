using System;

namespace Model.Models
{
	/// <summary>
	/// MES_BN_WorkShopMatching表实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class MES_BN_WorkShopMatching
	{

		/// <summary>
		/// 
		/// </summary>
		public int ID { get; set; } 

		/// <summary>
		/// 工艺BOM编号
		/// </summary>
		public string PartCode { get; set; } 

		/// <summary>
		/// 工艺类型
		/// </summary>
		public string ProcessType { get; set; } 

		/// <summary>
		/// 车间编号
		/// </summary>
		public string WorkShopCode { get; set; } 

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

		/// <summary>
		/// 根零件编号
		/// </summary>
		public string RootPartCode { get; set; } 

		/// <summary>
		/// 父级编号
		/// </summary>
		public string ParentCode { get; set; } 

		/// <summary>
		/// 合同编号
		/// </summary>
		public string ContractCode { get; set; } 

		/// <summary>
		/// 是否可用
		/// </summary>
		public int? IsEnable { get; set; } 

	}
}

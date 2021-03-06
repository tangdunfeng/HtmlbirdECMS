﻿// ===============================================================================
//  产品名称：网鸟电子商务管理系统(Htmlbird ECMS)
//  产品作者：YMind Chan
//  版权所有：网鸟IT技术论坛 颜铭工作室
// ===============================================================================
//  Copyright © Htmlbird.Net. All rights reserved .
//  官方网站：http://www.htmlbird.net/
//  技术论坛：http://bbs.htmlbird.net/
// ===============================================================================
using System;

namespace Net.Htmlbird.Framework.Web.Handlers
{
	/// <summary>
	/// 表示 <see cref="JsonPHttpHandlerBase"/> 的页面参数。
	/// </summary>
	[Serializable]
	public class JsonPHttpHandlerArgs : HttpHandlerArgs
	{
		/// <summary>
		/// 获取 JsonP 回调函数名称。
		/// </summary>
		public string CallbackName { get { return GetQuery("callback", "jsoncallback"); } }
	}
}
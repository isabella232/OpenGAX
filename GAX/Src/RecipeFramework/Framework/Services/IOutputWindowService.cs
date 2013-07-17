﻿//===================================================================================
// Microsoft patterns & practices
// Guidance Automation Extensions
//===================================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// License: MS-LPL
//===================================================================================

#region Using directives

using System;
using System.Text;

#endregion

namespace Microsoft.Practices.RecipeFramework.Services
{
	/// <summary>
	/// Service to display messages in the Visual Studio Output window
	/// </summary>
	public interface IOutputWindowService
	{
		/// <summary>
		/// Displays the <paramref name="message"/> in the output window
		/// </summary>
		/// <param name="message">The message to display.</param>
		void Display(string message);
	}
}

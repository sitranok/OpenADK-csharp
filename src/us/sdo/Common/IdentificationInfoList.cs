// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;

namespace OpenADK.Library.us.Common{

/// <summary>An IdentificationInfoList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class IdentificationInfoList : SifKeyedList<IdentificationInfo>
{
	/// <summary>
	/// Creates an instance of an IdentificationInfoList
	/// </summary>
	public IdentificationInfoList() : base ( CommonDTD.IDENTIFICATIONINFOLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="identificationInfo">From 0147 Identification System (subset)</param>
	///
	public IdentificationInfoList( IdentificationInfo identificationInfo ) : base( CommonDTD.IDENTIFICATIONINFOLIST )
	{
		this.SafeAddChild( CommonDTD.IDENTIFICATIONINFOLIST_IDENTIFICATIONINFO, identificationInfo );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected IdentificationInfoList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;IdentificationInfo&gt;</c> element.</summary>
	/// <param name="Code">Code indicating which identification system is used.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;IdentificationInfo&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setIdentificationInfo</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddIdentificationInfo</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void AddIdentificationInfo( IdentificationSystem Code, string Value ) {
		AddChild( CommonDTD.IDENTIFICATIONINFOLIST_IDENTIFICATIONINFO, new IdentificationInfo( Code, Value ) );
	}

}}

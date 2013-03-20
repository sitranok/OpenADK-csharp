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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Hrfin{

/// <summary>An OtherLEAs</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class OtherLEAs : SifKeyedList<LEAInfoRefId>
{
	/// <summary>
	/// Creates an instance of an OtherLEAs
	/// </summary>
	public OtherLEAs() : base ( HrfinDTD.OTHERLEAS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="leaInfoRefId">The ID (GUID) of an other related education agency, such as a regional service agency.</param>
	///
	public OtherLEAs( LEAInfoRefId leaInfoRefId ) : base( HrfinDTD.OTHERLEAS )
	{
		this.SafeAddChild( HrfinDTD.OTHERLEAS_LEAINFOREFID, leaInfoRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected OtherLEAs( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;LEAInfoRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;LEAInfoRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLEAInfoRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddLEAInfoRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddLEAInfoRefId( string Value ) {
		AddChild( HrfinDTD.OTHERLEAS_LEAINFOREFID, new LEAInfoRefId( Value ) );
	}

}}

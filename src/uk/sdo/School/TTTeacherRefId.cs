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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.School{

/// <summary>A TTTeacherRefId</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class TTTeacherRefId : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a TTTeacherRefId
	/// </summary>
	public TTTeacherRefId() : base ( SchoolDTD.TTTEACHERREFID ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="value">Gets or sets the content value of the &amp;lt;TTTeacherRefId&amp;gt; element</param>
	///
	public TTTeacherRefId( string value ) : base( SchoolDTD.TTTEACHERREFID )
	{
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TTTeacherRefId( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { SchoolDTD.TTTEACHERREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TTTeacherRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;TTTeacherRefId&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.TTTEACHERREFID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.TTTEACHERREFID, new SifString( value ), value );
		}
	}

}}

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

namespace OpenADK.Library.us.Programs{

/// <summary>A ProjectedExitReason</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class ProjectedExitReason : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ProjectedExitReason
	/// </summary>
	public ProjectedExitReason() : base ( ProgramsDTD.PROJECTEDEXITREASON ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="codeset">Identifies source of value provided.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;ProjectedExitReason&amp;gt; element</param>
	///
	public ProjectedExitReason( Codeset codeset, string value ) : base( ProgramsDTD.PROJECTEDEXITREASON )
	{
		this.SetCodeset( codeset );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ProjectedExitReason( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ProgramsDTD.PROJECTEDEXITREASON_CODESET }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProjectedExitReason&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;ProjectedExitReason&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.PROJECTEDEXITREASON ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.PROJECTEDEXITREASON, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Codeset</c> attribute.
	/// </summary>
	/// <value> The <c>Codeset</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Identifies source of value provided."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Codeset
	{
		get
		{ 
			return GetFieldValue( ProgramsDTD.PROJECTEDEXITREASON_CODESET );
		}
		set
		{
			SetField( ProgramsDTD.PROJECTEDEXITREASON_CODESET, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Codeset</c> attribute.
	/// </summary>
	/// <param name="val">A Codeset object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Identifies source of value provided."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCodeset( Codeset val )
	{
		SetField( ProgramsDTD.PROJECTEDEXITREASON_CODESET, val );
	}

}}

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

/// <summary>A ServicingPublicAgency</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class ServicingPublicAgency : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ServicingPublicAgency
	/// </summary>
	public ServicingPublicAgency() : base ( ProgramsDTD.SERVICINGPUBLICAGENCY ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifRefObject">A SIF_RefObject</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;ServicingPublicAgency&amp;gt; element</param>
	///
	public ServicingPublicAgency( string sifRefObject, string value ) : base( ProgramsDTD.SERVICINGPUBLICAGENCY )
	{
		this.SIF_RefObject = sifRefObject;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ServicingPublicAgency( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ProgramsDTD.SERVICINGPUBLICAGENCY_SIF_REFOBJECT }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ServicingPublicAgency&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;ServicingPublicAgency&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.SERVICINGPUBLICAGENCY ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.SERVICINGPUBLICAGENCY, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SIF_RefObject</c> attribute.
	/// </summary>
	/// <value> The <c>SIF_RefObject</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SIF_RefObject
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.SERVICINGPUBLICAGENCY_SIF_REFOBJECT ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.SERVICINGPUBLICAGENCY_SIF_REFOBJECT, new SifString( value ), value );
		}
	}

}}

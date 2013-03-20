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

namespace OpenADK.Library.Infra{

/// <summary>A SIF_ProtocolName</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_ProtocolName : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SIF_ProtocolName
	/// </summary>
	public SIF_ProtocolName() : base ( InfraDTD.SIF_PROTOCOLNAME ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="value">Gets or sets the content value of the &amp;lt;SIF_ProtocolName&amp;gt; element</param>
	///
	public SIF_ProtocolName( SIFProtocolName value ) : base( InfraDTD.SIF_PROTOCOLNAME )
	{
		this.SetValue( value );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_ProtocolName( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_PROTOCOLNAME }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ProtocolName&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;SIF_ProtocolName&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Value
	{
		get
		{ 
			return GetFieldValue( InfraDTD.SIF_PROTOCOLNAME );
		}
		set
		{
			SetField( InfraDTD.SIF_PROTOCOLNAME, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Value&gt;</c> element.
	/// </summary>
	/// <param name="val">A SIFProtocolName object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;SIF_ProtocolName&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetValue( SIFProtocolName val )
	{
		SetField( InfraDTD.SIF_PROTOCOLNAME, val );
	}

}}

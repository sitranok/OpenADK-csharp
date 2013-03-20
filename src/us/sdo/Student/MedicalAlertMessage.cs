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

namespace OpenADK.Library.us.Student{

/// <summary>A MedicalAlertMessage</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class MedicalAlertMessage : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a MedicalAlertMessage
	/// </summary>
	public MedicalAlertMessage() : base ( StudentDTD.MEDICALALERTMESSAGE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="severity">The level of severity of this medical alert.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;MedicalAlertMessage&amp;gt; element</param>
	///
	public MedicalAlertMessage( MedicalAlertMessageSeverity severity, string value ) : base( StudentDTD.MEDICALALERTMESSAGE )
	{
		this.SetSeverity( severity );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MedicalAlertMessage( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.MEDICALALERTMESSAGE_SEVERITY }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MedicalAlertMessage&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;MedicalAlertMessage&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.MEDICALALERTMESSAGE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.MEDICALALERTMESSAGE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Severity</c> attribute.
	/// </summary>
	/// <value> The <c>Severity</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The level of severity of this medical alert."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Severity
	{
		get
		{ 
			return GetFieldValue( StudentDTD.MEDICALALERTMESSAGE_SEVERITY );
		}
		set
		{
			SetField( StudentDTD.MEDICALALERTMESSAGE_SEVERITY, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Severity</c> attribute.
	/// </summary>
	/// <param name="val">A MedicalAlertMessageSeverity object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The level of severity of this medical alert."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSeverity( MedicalAlertMessageSeverity val )
	{
		SetField( StudentDTD.MEDICALALERTMESSAGE_SEVERITY, val );
	}

}}

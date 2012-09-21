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

/// <summary>The specific group of duties or responsibilities of position.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class ProgramType : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ProgramType
	/// </summary>
	public ProgramType() : base ( CommonDTD.PROGRAMTYPE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">The type of the program. Type identifies the list of values.</param>
	///
	public ProgramType( StudentFamilyProgramType code ) : base( CommonDTD.PROGRAMTYPE )
	{
		this.SetCode( code );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ProgramType( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.PROGRAMTYPE_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The type of the program. Type identifies the list of values."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( CommonDTD.PROGRAMTYPE_CODE );
		}
		set
		{
			SetField( CommonDTD.PROGRAMTYPE_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A StudentFamilyProgramType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The type of the program. Type identifies the list of values."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetCode( StudentFamilyProgramType val )
	{
		SetField( CommonDTD.PROGRAMTYPE_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "NCES 0229 Program Type Codeset"</para>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( CommonDTD.PROGRAMTYPE_OTHERCODELIST);
		}
		set
		{
			RemoveChild( CommonDTD.PROGRAMTYPE_OTHERCODELIST);
			if( value != null)
			{
				AddChild( CommonDTD.PROGRAMTYPE_OTHERCODELIST, value );
			}
		}
	}

}}
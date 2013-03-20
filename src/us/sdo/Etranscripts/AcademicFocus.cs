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
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>An AcademicFocus</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.2</para>
/// </remarks>
[Serializable]
public class AcademicFocus : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an AcademicFocus
	/// </summary>
	public AcademicFocus() : base ( EtranscriptsDTD.ACADEMICFOCUS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">A code to depict the focus of the educational program (replaces deprecated AcademicTrack.</param>
	///
	public AcademicFocus( ProgramTypeCode code ) : base( EtranscriptsDTD.ACADEMICFOCUS )
	{
		this.SetCode( code );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AcademicFocus( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { EtranscriptsDTD.ACADEMICFOCUS_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A code to depict the focus of the educational program (replaces deprecated AcademicTrack."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( EtranscriptsDTD.ACADEMICFOCUS_CODE );
		}
		set
		{
			SetField( EtranscriptsDTD.ACADEMICFOCUS_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A ProgramTypeCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A code to depict the focus of the educational program (replaces deprecated AcademicTrack."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void SetCode( ProgramTypeCode val )
	{
		SetField( EtranscriptsDTD.ACADEMICFOCUS_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Alternate codes indicating the general nature and difficulty of the educational program."</para>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( EtranscriptsDTD.ACADEMICFOCUS_OTHERCODELIST);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACADEMICFOCUS_OTHERCODELIST);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACADEMICFOCUS_OTHERCODELIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ExtendedElements&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ExtendedElements </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_ExtendedElements</c>, set <c>SIF_ExtendedElements</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public SIF_ExtendedElements SIF_ExtendedElements
	{
		get
		{
			return (SIF_ExtendedElements)GetChild( EtranscriptsDTD.ACADEMICFOCUS_SIF_EXTENDEDELEMENTS);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACADEMICFOCUS_SIF_EXTENDEDELEMENTS);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACADEMICFOCUS_SIF_EXTENDEDELEMENTS, value );
			}
		}
	}

}}

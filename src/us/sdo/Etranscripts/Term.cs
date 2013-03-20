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

/// <summary>A Term</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Term : SifElement
{
	/// <summary>
	/// Creates an instance of a Term
	/// </summary>
	public Term() : base ( EtranscriptsDTD.TERM ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Term( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Sets the value of the <c>&lt;TermInfoData&gt;</c> element.</summary>
	/// <param name="SchoolAttendedRefId">Reference to the school of record for the courses being taken (see SchoolAttended).</param>
	///<remarks>
	/// <para>This form of <c>setTermInfoData</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>TermInfoData</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetTermInfoData( string SchoolAttendedRefId ) {
		RemoveChild( EtranscriptsDTD.TERM_TERMINFODATA);
		AddChild( EtranscriptsDTD.TERM_TERMINFODATA, new TermInfoData( SchoolAttendedRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TermInfoData&gt;</c> element.
	/// </summary>
	/// <value> A TermInfoData </value>
	/// <remarks>
	/// <para>To remove the <c>TermInfoData</c>, set <c>TermInfoData</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public TermInfoData TermInfoData
	{
		get
		{
			return (TermInfoData)GetChild( EtranscriptsDTD.TERM_TERMINFODATA);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.TERM_TERMINFODATA);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.TERM_TERMINFODATA, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Courses&gt;</c> element.
	/// </summary>
	/// <value> A Courses </value>
	/// <remarks>
	/// <para>To remove the <c>Courses</c>, set <c>Courses</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Courses Courses
	{
		get
		{
			return (Courses)GetChild( EtranscriptsDTD.TERM_COURSES);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.TERM_COURSES);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.TERM_COURSES, value );
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
			return (SIF_ExtendedElements)GetChild( EtranscriptsDTD.TERM_SIF_EXTENDEDELEMENTS);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.TERM_SIF_EXTENDEDELEMENTS);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.TERM_SIF_EXTENDEDELEMENTS, value );
			}
		}
	}

}}

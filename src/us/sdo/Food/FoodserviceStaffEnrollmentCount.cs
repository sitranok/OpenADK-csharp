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

namespace OpenADK.Library.us.Food{

/// <summary>A FoodserviceStaffEnrollmentCount</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class FoodserviceStaffEnrollmentCount : SifDataObject
{
	/// <summary>
	/// Creates an instance of a FoodserviceStaffEnrollmentCount
	/// </summary>
	public FoodserviceStaffEnrollmentCount() : base( Adk.SifVersion, FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="schoolInfoRefId">Reference to SchoolInfo</param>
	///<param name="date">Date the count is taken.</param>
	///<param name="program">A Program</param>
	///<param name="counts">A Counts</param>
	///
	public FoodserviceStaffEnrollmentCount( string schoolInfoRefId, DateTime? date, Program program, Counts counts ) : base( Adk.SifVersion, FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT )
	{
		this.SchoolInfoRefId = schoolInfoRefId;
		this.Date = date;
		this.Program = program;
		this.Counts = counts;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FoodserviceStaffEnrollmentCount( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_SCHOOLINFOREFID, FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_DATE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Reference to SchoolInfo"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Date</c> attribute.
	/// </summary>
	/// <value> The <c>Date</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Date the count is taken."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? Date
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_DATE ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_DATE, new SifDate( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Program&gt;</c> element.</summary>
	/// <param name="Type">The type of the program. Type identifies the list of values.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Program&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setProgram</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Program</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetProgram( FinancialProgram Type, string Value ) {
		RemoveChild( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_PROGRAM);
		AddChild( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_PROGRAM, new Program( Type, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Program&gt;</c> element.
	/// </summary>
	/// <value> A Program </value>
	/// <remarks>
	/// <para>To remove the <c>Program</c>, set <c>Program</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Program Program
	{
		get
		{
			return (Program)GetChild( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_PROGRAM);
		}
		set
		{
			RemoveChild( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_PROGRAM);
			if( value != null)
			{
				AddChild( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_PROGRAM, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Counts&gt;</c> element.
	/// </summary>
	/// <value> A Counts </value>
	/// <remarks>
	/// <para>To remove the <c>Counts</c>, set <c>Counts</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Counts Counts
	{
		get
		{
			return (Counts)GetChild( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_COUNTS);
		}
		set
		{
			RemoveChild( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_COUNTS);
			if( value != null)
			{
				AddChild( FoodDTD.FOODSERVICESTAFFENROLLMENTCOUNT_COUNTS, value );
			}
		}
	}

}}

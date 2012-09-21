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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Student{

/// <summary>A StudentPicture</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class StudentPicture : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StudentPicture
	/// </summary>
	public StudentPicture() : base( Adk.SifVersion, StudentDTD.STUDENTPICTURE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="studentPersonalRefId">This is the GUID of the student whose picture this is.</param>
	///<param name="schoolYear">School year for which this enrollment is applicable, expressed as the four-digit year in which the school year        ends (e.g. 2007 for the 2006-07 school year).</param>
	///<param name="pictureSource">A PictureSource</param>
	///
	public StudentPicture( string studentPersonalRefId, int? schoolYear, PictureSource pictureSource ) : base( Adk.SifVersion, StudentDTD.STUDENTPICTURE )
	{
		this.StudentPersonalRefId = studentPersonalRefId;
		this.SchoolYear = schoolYear;
		this.PictureSource = pictureSource;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentPicture( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STUDENTPICTURE_STUDENTPERSONALREFID, StudentDTD.STUDENTPICTURE_SCHOOLYEAR }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>StudentPersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "This is the GUID of the student whose picture this is."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTPICTURE_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTPICTURE_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolYear</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolYear</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "School year for which this enrollment is applicable, expressed as the four-digit year in which the school year        ends (e.g. 2007 for the 2006-07 school year)."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.STUDENTPICTURE_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTPICTURE_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;PictureSource&gt;</c> element.</summary>
	/// <param name="Type">The way the picture is specified.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PictureSource&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setPictureSource</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PictureSource</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPictureSource( PictureSourceType Type, string Value ) {
		RemoveChild( StudentDTD.STUDENTPICTURE_PICTURESOURCE);
		AddChild( StudentDTD.STUDENTPICTURE_PICTURESOURCE, new PictureSource( Type, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PictureSource&gt;</c> element.
	/// </summary>
	/// <value> A PictureSource </value>
	/// <remarks>
	/// <para>To remove the <c>PictureSource</c>, set <c>PictureSource</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PictureSource PictureSource
	{
		get
		{
			return (PictureSource)GetChild( StudentDTD.STUDENTPICTURE_PICTURESOURCE);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTPICTURE_PICTURESOURCE);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTPICTURE_PICTURESOURCE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OKToPublish&gt;</c> element.
	/// </summary>
	/// <value> The <c>OKToPublish</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Can the picture be published?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string OKToPublish
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTPICTURE_OKTOPUBLISH );
		}
		set
		{
			SetField( StudentDTD.STUDENTPICTURE_OKTOPUBLISH, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;OKToPublish&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Can the picture be published?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetOKToPublish( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTPICTURE_OKTOPUBLISH, val );
	}

}}
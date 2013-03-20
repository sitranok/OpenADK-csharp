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

/// <summary>This object provides information about the classes being correlated for some program purpose, for example, career tech or team scheduling.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class SectionCorrelation : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SectionCorrelation
	/// </summary>
	public SectionCorrelation() : base( Adk.SifVersion, StudentDTD.SECTIONCORRELATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The Id (GUID) that uniquely identifies this correlation.</param>
	///
	public SectionCorrelation( string refId ) : base( Adk.SifVersion, StudentDTD.SECTIONCORRELATION )
	{
		this.RefId = refId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SectionCorrelation( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.SECTIONCORRELATION_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The Id (GUID) that uniquely identifies this correlation."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SECTIONCORRELATION_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONCORRELATION_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CorrelationName&gt;</c> element.
	/// </summary>
	/// <value> The <c>CorrelationName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The classes being correlated for some program purpose, for example, career tech or team scheduling."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string CorrelationName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SECTIONCORRELATION_CORRELATIONNAME ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONCORRELATION_CORRELATIONNAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;CorrelationType&gt;</c> element.</summary>
	/// <param name="Code">The code for the type of correlation</param>
	///<remarks>
	/// <para>This form of <c>setCorrelationType</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>CorrelationType</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetCorrelationType( CodeCorrelation Code ) {
		RemoveChild( StudentDTD.SECTIONCORRELATION_CORRELATIONTYPE);
		AddChild( StudentDTD.SECTIONCORRELATION_CORRELATIONTYPE, new CorrelationType( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CorrelationType&gt;</c> element.
	/// </summary>
	/// <value> A CorrelationType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Type of correlation"</para>
	/// <para>To remove the <c>CorrelationType</c>, set <c>CorrelationType</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public CorrelationType CorrelationType
	{
		get
		{
			return (CorrelationType)GetChild( StudentDTD.SECTIONCORRELATION_CORRELATIONTYPE);
		}
		set
		{
			RemoveChild( StudentDTD.SECTIONCORRELATION_CORRELATIONTYPE);
			if( value != null)
			{
				AddChild( StudentDTD.SECTIONCORRELATION_CORRELATIONTYPE, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;CorrelationSectionList&gt;</c> element.</summary>
	/// <param name="CorrelationSection">Reference to a SectionInfo object to be correlated.</param>
	///<remarks>
	/// <para>This form of <c>setCorrelationSectionList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>CorrelationSectionList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetCorrelationSectionList( CorrelationSection CorrelationSection ) {
		RemoveChild( StudentDTD.SECTIONCORRELATION_CORRELATIONSECTIONLIST);
		AddChild( StudentDTD.SECTIONCORRELATION_CORRELATIONSECTIONLIST, new CorrelationSectionList( CorrelationSection ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CorrelationSectionList&gt;</c> element.
	/// </summary>
	/// <value> A CorrelationSectionList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The list of SectionInfo objects being correlated."</para>
	/// <para>To remove the <c>CorrelationSectionList</c>, set <c>CorrelationSectionList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public CorrelationSectionList CorrelationSectionList
	{
		get
		{
			return (CorrelationSectionList)GetChild( StudentDTD.SECTIONCORRELATION_CORRELATIONSECTIONLIST);
		}
		set
		{
			RemoveChild( StudentDTD.SECTIONCORRELATION_CORRELATIONSECTIONLIST);
			if( value != null)
			{
				AddChild( StudentDTD.SECTIONCORRELATION_CORRELATIONSECTIONLIST, value );
			}
		}
	}

}}

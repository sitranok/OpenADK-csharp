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
using OpenADK.Library.Infra;

namespace OpenADK.Library.au.Reporting{

/// <summary>This object is here only as necessary for the ADK, but not supported in the UK data model</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SIF_ReportObject : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SIF_ReportObject
	/// </summary>
	public SIF_ReportObject() : base( Adk.SifVersion, ReportingDTD.SIF_REPORTOBJECT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) that uniquely identifies this instance of a report.</param>
	///
	public SIF_ReportObject( string refId ) : base( Adk.SifVersion, ReportingDTD.SIF_REPORTOBJECT )
	{
		this.RefId = refId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_ReportObject( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ReportingDTD.SIF_REPORTOBJECT_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies this instance of a report."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.SIF_REPORTOBJECT_REFID ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.SIF_REPORTOBJECT_REFID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ReportInfo&gt;</c> element.</summary>
	/// <param name="ReportManifestRefId">The report manifest corresponding to this report.</param>
	/// <param name="CalculationDate">The date on which the report was calculated.</param>
	/// <param name="SubmissionNumber">A number that identifies the submission; beginning at 1 and incremented each time a submission is done for a particular report; used to indicate resubmission(s).</param>
	/// <param name="SubmissionReason">Reason for the report submission.</param>
	///<remarks>
	/// <para>This form of <c>setReportInfo</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ReportInfo</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetReportInfo( string ReportManifestRefId, DateTime? CalculationDate, int? SubmissionNumber, SubmissionReason SubmissionReason ) {
		RemoveChild( ReportingDTD.SIF_REPORTOBJECT_REPORTINFO);
		AddChild( ReportingDTD.SIF_REPORTOBJECT_REPORTINFO, new ReportInfo( ReportManifestRefId, CalculationDate, SubmissionNumber, SubmissionReason ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReportInfo&gt;</c> element.
	/// </summary>
	/// <value> A ReportInfo </value>
	/// <remarks>
	/// <para>To remove the <c>ReportInfo</c>, set <c>ReportInfo</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public ReportInfo ReportInfo
	{
		get
		{
			return (ReportInfo)GetChild( ReportingDTD.SIF_REPORTOBJECT_REPORTINFO);
		}
		set
		{
			RemoveChild( ReportingDTD.SIF_REPORTOBJECT_REPORTINFO);
			if( value != null)
			{
				AddChild( ReportingDTD.SIF_REPORTOBJECT_REPORTINFO, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ReportData&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ReportData&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setReportData</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ReportData</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetReportData( string Value ) {
		RemoveChild( ReportingDTD.SIF_REPORTOBJECT_REPORTDATA);
		AddChild( ReportingDTD.SIF_REPORTOBJECT_REPORTDATA, new ReportData( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReportData&gt;</c> element.
	/// </summary>
	/// <value> A ReportData </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "
	///         Container element for the report content; one valid SIF object can occur as a child here. This element is conditional.
	///         This element or ReportInfo or SIF_ExtendedQueryResults is included but never at the same time.
	///         See examples of the usage of the object below.
	///       "</para>
	/// <para>To remove the <c>ReportData</c>, set <c>ReportData</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public ReportData ReportData
	{
		get
		{
			return (ReportData)GetChild( ReportingDTD.SIF_REPORTOBJECT_REPORTDATA);
		}
		set
		{
			RemoveChild( ReportingDTD.SIF_REPORTOBJECT_REPORTDATA);
			if( value != null)
			{
				AddChild( ReportingDTD.SIF_REPORTOBJECT_REPORTDATA, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_ExtendedQueryResults&gt;</c> element.</summary>
	/// <param name="SifColumnHeaders">A SIF_ColumnHeaders</param>
	/// <param name="SifRows">A SIF_Rows</param>
	///<remarks>
	/// <para>This form of <c>setSIF_ExtendedQueryResults</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_ExtendedQueryResults</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_ExtendedQueryResults( SIFColumnHeader SifColumnHeaders, SIF_Rows SifRows ) {
		RemoveChild( ReportingDTD.SIF_REPORTOBJECT_SIF_EXTENDEDQUERYRESULTS);
		AddChild( ReportingDTD.SIF_REPORTOBJECT_SIF_EXTENDEDQUERYRESULTS, new SIF_ExtendedQueryResults( SifColumnHeaders, SifRows ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ExtendedQueryResults&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ExtendedQueryResults </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "
	///         The report content resulting from a SIF_ExtendedQuery-based report.  This element is conditional.
	///         This element or ReportInfo or ReportData is included but never at the same time.
	///       "</para>
	/// <para>To remove the <c>SIF_ExtendedQueryResults</c>, set <c>SIF_ExtendedQueryResults</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_ExtendedQueryResults SIF_ExtendedQueryResults
	{
		get
		{
			return (SIF_ExtendedQueryResults)GetChild( ReportingDTD.SIF_REPORTOBJECT_SIF_EXTENDEDQUERYRESULTS);
		}
		set
		{
			RemoveChild( ReportingDTD.SIF_REPORTOBJECT_SIF_EXTENDEDQUERYRESULTS);
			if( value != null)
			{
				AddChild( ReportingDTD.SIF_REPORTOBJECT_SIF_EXTENDEDQUERYRESULTS, value );
			}
		}
	}

}}

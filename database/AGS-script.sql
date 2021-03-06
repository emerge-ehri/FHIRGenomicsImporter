CREATE DATABASE [AGS];
GO


USE [AGS]
GO
/****** Object:  Table [dbo].[AGSResultMessageFiles]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSResultMessageFiles](
	[MessageID] [int] NOT NULL,
	[FileName] [varchar](255) NOT NULL,
	[OriginalFileName] [varchar](255) NULL,
	[MessageFileTypeID] [int] NULL,
	[Data] [varbinary](max) NULL,
 CONSTRAINT [PK_AGSResultMessageFiles] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC,
	[FileName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSObservationGroupMembers]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSObservationGroupMembers](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NOT NULL,
	[ObservationID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [varchar](255) NULL,
	[DisplayOrder] [smallint] NULL,
	[CodeSystem] [nvarchar](255) NULL,
	[CodeValue] [nvarchar](255) NULL,
	[CodeName] [nvarchar](255) NULL,
 CONSTRAINT [PK_AGSObservationGroupMembers] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSObservationGroups]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSObservationGroups](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Category] [tinyint] NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [varchar](255) NULL,
	[DisplayOrder] [smallint] NULL,
	[PatientID] [int] NULL,
	[ApprovedOn] [datetime] NULL,
	[ApprovedBy] [varchar](255) NULL,
	[ReleasedOn] [datetime] NULL,
	[ReleasedBy] [varchar](255) NULL,
	[CodeValue] [varchar](50) NULL,
	[CodeSystem] [varchar](50) NULL,
	[CodeName] [varchar](500) NULL,
 CONSTRAINT [PK_AGSObservationGroups] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSObservationResultAttributes]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSObservationResultAttributes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ObservationID] [int] NOT NULL,
	[ResultAttributeID] [int] NOT NULL,
 CONSTRAINT [PK_AGSObservationResultAttributes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSObservations]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSObservations](
	[ObservationID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[CodeValue] [varchar](50) NOT NULL,
	[CodeSystem] [varchar](50) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Value] [varchar](255) NULL,
	[ClinicalComments] [nvarchar](max) NULL,
	[InternalComments] [nvarchar](max) NULL,
	[ModuleID] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [varchar](255) NULL,
	[ApprovedOn] [datetime] NULL,
	[ApprovedBy] [varchar](255) NULL,
	[ReleasedOn] [datetime] NULL,
	[ReleasedBy] [varchar](255) NULL,
	[AccessionNumber] [varchar](25) NULL,
	[CodeName] [varchar](500) NULL,
	[AbnormalFlag] [varchar](50) NULL,
 CONSTRAINT [PK_AGSObservations] PRIMARY KEY CLUSTERED 
(
	[ObservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSPatients]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSPatients](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](80) NOT NULL,
	[FirstName] [varchar](80) NOT NULL,
	[BirthDate] [datetime] NULL,
	[MRN] [varchar](255) NOT NULL,
	[Gender] [varchar](50) NULL,
 CONSTRAINT [PK_AGSPatients] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSResultAttributes]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSResultAttributes](
	[ResultAttributeID] [int] IDENTITY(1,1) NOT NULL,
	[MessageID] [int] NOT NULL,
	[AttributeID] [int] NOT NULL,
	[AttributeName] [varchar](80) NOT NULL,
	[ParentResultAttributeID] [int] NULL,
	[Value] [nvarchar](max) NULL,
	[Lineage] [varchar](max) NULL,
 CONSTRAINT [PK_AGSResultAttributes] PRIMARY KEY CLUSTERED 
(
	[ResultAttributeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSResultMessageFileTypes]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSResultMessageFileTypes](
	[MessageFileTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ViewAction] [nvarchar](50) NOT NULL,
	[Data] [varbinary](max) NULL,
	[CreatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_AGSResultMessageFileTypes] PRIMARY KEY CLUSTERED 
(
	[MessageFileTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSResultMessages]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSResultMessages](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[Sender] [nvarchar](255) NOT NULL,
	[Format] [varchar](255) NOT NULL,
	[ReceivedOn] [datetime] NOT NULL,
	[ProcessedOn] [datetime] NOT NULL,
	[Status] [varchar](25) NOT NULL,
 CONSTRAINT [PK_AGSResultMessages] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSResultPatients]    Script Date: 4/15/2020 2:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSResultPatients](
	[MessageID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
 CONSTRAINT [PK_AGSResultPatients] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC,
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_LabResults]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vw_LabResults]
AS
SELECT DISTINCT 
			og.GroupID
            ,p.MRN
			, p.PatientID
			, msg.MessageID
			, msg.Sender
			, msg.ReceivedOn
			, msg.ProcessedOn
			, msg.Status
			, msg.Format
			, msgFile.OriginalFileName
			, msgFile.FileName
			, msgFile.Data			as XmlData
			, msgFileType.Name
			, msgFileType.ViewAction
			, msgFileType.Data		as XsltData
		--	, o.ObservationID
  FROM [AGS].[dbo].[AGSObservationGroups] og
        INNER JOIN dbo.AGSObservationGroupMembers ogm ON ogm.GroupID = og.GroupID
        INNER JOIN dbo.AGSObservations o ON o.ObservationID = ogm.ObservationID
        INNER JOIN dbo.AGSObservationResultAttributes ora ON ora.ObservationID = o.ObservationID
        INNER JOIN dbo.AGSResultAttributes ra ON ra.ResultAttributeID = ora.ResultAttributeID
        INNER JOIN dbo.AGSResultMessages msg ON msg.MessageID = ra.MessageID
        INNER JOIN dbo.AGSResultMessageFiles msgFile ON msgFile.MessageID = msg.MessageID
		LEFT OUTER JOIN dbo.AGSResultPatients AS rsltPat ON msg.MessageID = rsltPat.MessageID
		LEFT OUTER JOIN dbo.AGSPatients AS p ON p.PatientID = rsltPat.PatientID
		LEFT OUTER JOIN dbo.AGSResultMessageFileTypes AS msgFileType ON msgFile.MessageFileTypeID = msgFileType.MessageFileTypeID




GO
/****** Object:  Table [dbo].[AGSAttributes]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSAttributes](
	[AttributeID] [int] NOT NULL,
	[Name] [varchar](80) NOT NULL,
	[ParentID] [int] NOT NULL,
	[Description] [varchar](255) NOT NULL,
	[AttributeTypeID] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[DeletedOn] [datetime] NULL,
 CONSTRAINT [PK_AGSAttributes] PRIMARY KEY CLUSTERED 
(
	[AttributeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_ResultGenes]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Vw_Result_Samples – MessageID/Name/Value/(PatientId) – Only sample data
CREATE VIEW [dbo].[vw_ResultGenes] AS
SELECT 
  rm.MessageID 
  ,p.PatientId
  ,ra.ResultAttributeID
  ,ra.AttributeID
  ,ra.AttributeName
  ,ra.Value
FROM AGSResultMessages rm 
JOIN AGSResultAttributes ra on (ra.[MessageID] = rm.[MessageID])
JOIN AGSResultPatients rp on (rm.MessageID = rp.MessageID)
JOIN AGSPatients p on (rp.[PatientID] = p.[PatientID])
WHERE 
  AttributeID in (
	SELECT AttributeID
	FROM [AGSAttributes] 
	WHERE ParentID in (
		SELECT AttributeID
		FROM [AGSAttributes] 
		WHERE ParentID = 100
	  )
  )
  
  
GO
/****** Object:  View [dbo].[vw_ObservationResultGenes]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Vw_Result_Samples – MessageID/Name/Value/(PatientId) – Only sample data
CREATE VIEW [dbo].[vw_ObservationResultGenes] AS
SELECT ora.ObservationID, rg.*
  ,(SELECT TOP 1 Value FROM AGSResultAttributes ra WHERE ra.[MessageID] = rg.[MessageID] and AttributeID = 22) as [SampleType]
  ,(SELECT TOP 1 Value FROM AGSResultAttributes ra WHERE ra.[MessageID] = rg.[MessageID] and AttributeID = 23) as [SignedBy]
FROM vw_ResultGenes rg
JOIN AGSObservationResultAttributes ora on (ora.ResultAttributeID = rg.ResultAttributeID)
GO
/****** Object:  Table [dbo].[AGSCommunications]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSCommunications](
	[CommunicationID] [int] IDENTITY(1,1) NOT NULL,
	[ObservationGroupID] [int] NOT NULL,
	[CommunicationType] [tinyint] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[Message] [nvarchar](max) NULL,
	[FilePath] [nvarchar](260) NULL,
	[FileName] [nvarchar](255) NULL,
	[MimeType] [nvarchar](255) NULL,
	[SentOn] [datetime] NOT NULL,
	[SentBy] [nvarchar](255) NOT NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](255) NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [nvarchar](255) NULL,
	[TemplateId] [int] NULL,
	[ContentData] [varchar](max) NULL,
	[UploadedData] [image] NULL,
 CONSTRAINT [PK_AGSCommunications] PRIMARY KEY CLUSTERED 
(
	[CommunicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_Communications]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[vw_Communications]
AS
SELECT DISTINCT 
                         AGSCommunications.ObservationGroupID, AGSCommunications.Message, AGSCommunications.Status, AGSCommunications.FilePath, 
                         AGSCommunications.FileName, AGSCommunications.SentOn, AGSCommunications.SentBy, AGSCommunications.MimeType, AGSCommunications.UpdatedOn, 
                         AGSCommunications.UpdatedBy, AGSCommunications.DeletedOn, AGSCommunications.DeletedBy, AGSObservationGroupMembers.GroupID, 
                         AGSCommunications.CommunicationType, AGSCommunications.CommunicationID
FROM            AGSObservations INNER JOIN
                         AGSObservationGroupMembers ON AGSObservations.ObservationID = AGSObservationGroupMembers.ObservationID INNER JOIN
                         AGSCommunications INNER JOIN
                         AGSObservationGroups ON AGSCommunications.ObservationGroupID = AGSObservationGroups.GroupID ON 
                         AGSObservationGroupMembers.GroupID = AGSObservationGroups.GroupID
WHERE        (AGSCommunications.DeletedBy IS NULL) OR
                         (AGSCommunications.DeletedBy = '')




GO
/****** Object:  Table [dbo].[AGSPatientCTMSData]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSPatientCTMSData](
	[PatientID] [int] NOT NULL,
	[MessageID] [int] NOT NULL,
	[StudyID] [varchar](500) NOT NULL,
	[IndicationForTesting] [varchar](5000) NULL,
	[DiseaseStatus] [varchar](500) NULL,
	[HasPreviouslyKnownMutations] [varchar](500) NULL,
	[PreviouslyKnownMutations] [varchar](500) NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_AGSPatientCTMSData] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC,
	[MessageID] ASC,
	[StudyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_ObservationGroups]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vw_ObservationGroups]
AS
with cteGroupMember
as
(
SELECT  ot.GroupID, 
		ot.ObservationID, 
		STUFF((SELECT DISTINCT ',' + CodeName
                FROM            AGSObservationGroupMembers iT
                WHERE        iT.GroupID = oT.GroupID FOR xml path('')), 1, 1, '') AS CodeNames, 
		STUFF((SELECT DISTINCT ',' + com.Message
				FROM            AGSObservationGroupMembers iT INNER JOIN
										[dbo].[AGSCommunications] com ON it.GroupID = com.ObservationGroupID
				WHERE        iT.GroupID = oT.GroupID AND com.[DeletedOn] IS NULL FOR xml path('')), 1, 1, '') AS Comments, 
		ot.DisplayOrder
FROM  AGSObservationGroupMembers oT
GROUP BY oT.groupid, ot.ObservationID, ot.DisplayOrder
), cteData 
AS
(SELECT DISTINCT 
        grp.[GroupID], 
		grp.[Name], 
		grp.[CreatedOn], 
		grp.[ApprovedOn], 
		grp.[ReleasedOn], 
		ob.[Status],
		p.PatientID, 
		RTRIM(COALESCE (p.LastName + ', ', '') + COALESCE (p.FirstName, '')) AS FullName, 
		p.LastName, 
        p.FirstName, 
		ISNULL(p.BirthDate, '1900-01-01') AS BirthDate, 
		p.MRN, 
		cteGroupMember.Comments, 
		cteGroupMember.CodeNames AS DisplayVarients, 
		cteGroupMember.DisplayOrder, 
		ob.ClinicalComments, 
        cteGroupMember.ObservationID,
		ctm.StudyID,						
		ctm.IndicationForTesting,			
		ctm.DiseaseStatus,					
		ctm.HasPreviouslyKnownMutations,	
		ctm.PreviouslyKnownMutations		
 FROM   cteGroupMember 
		INNER JOIN dbo.AGSObservationGroups AS grp ON cteGroupMember.GroupID = grp.GroupID 
		INNER JOIN dbo.AGSObservations AS ob ON cteGroupMember.ObservationID = ob.ObservationID 
		INNER JOIN dbo.AGSPatients AS p ON ob.PatientID = p.PatientID 
		INNER JOIN dbo.AGSResultPatients rp ON p.PatientID = rp.PatientID
		LEFT JOIN dbo.AGSPatientCTMSData ctm on ctm.PatientID = rp.PatientID
 WHERE        grp.Category <> 1
 )
    SELECT  TOP 100 PERCENT 
			grp.GroupID, 
			grp.ObservationID, 
			grp.PatientID, 
			grp.[Name] AS GroupName, 
			grp.[CreatedOn], 
			grp.[ApprovedOn], 
			grp.[ReleasedOn],
			grp.[Status], 
			grp.FullName, 
			grp.LastName, 
			grp.FirstName, 
            grp.BirthDate, 
			grp.MRN, 
			grp.Comments, 
			grp.DisplayVarients, 
			grp.DisplayOrder, 
			grp.ClinicalComments,
			grp.StudyID,					
			grp.IndicationForTesting,		
			grp.DiseaseStatus,				
			grp.HasPreviouslyKnownMutations,
			grp.PreviouslyKnownMutations
     FROM  cteData grp
     WHERE  EXISTS
            (SELECT        NULL
            FROM            cteData i
            WHERE        grp.GroupID = i.GroupID
            GROUP BY i.GroupID
            HAVING         grp.ObservationID = MAX(i.ObservationID))
     GROUP BY GroupID, MRN, ObservationID, PatientID, ApprovedOn, [Name], CreatedOn, [ReleasedOn], [Status], FullName, LastName, FirstName, 
			BirthDate, Comments, DisplayVarients, DisplayOrder, ClinicalComments,StudyID,IndicationForTesting,DiseaseStatus,
			HasPreviouslyKnownMutations,PreviouslyKnownMutations

GO
/****** Object:  View [dbo].[vw_Observations]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE VIEW [dbo].[vw_Observations]
AS


with cteGroupMember
as
(
select 
	ot.GroupID,
	ot.ObservationID,
	ot.DisplayOrder,
	STUFF((
		select distinct ',' + CodeName
		from AGSObservationGroupMembers iT
		where iT.GroupID = oT.GroupID
		for xml path('')), 1,1,'') as CodeNames
	,STUFF((
		select distinct ',' + com.Message
		from AGSObservationGroupMembers iT inner join [dbo].[AGSCommunications] com on it.GroupID = com.ObservationGroupID
		where iT.GroupID = oT.GroupID and com.[DeletedOn] is null
		for xml path('')), 1,1,'') as Comments
from AGSObservationGroupMembers oT
group by oT.groupid, ot.ObservationID,ot.DisplayOrder
)
SELECT distinct top 100 percent  ob.ObservationID, p.PatientID, RTRIM(COALESCE (p.LastName + ', ', '') + COALESCE (p.FirstName, '')) AS FullName, p.LastName, p.FirstName, p.BirthDate, p.MRN 
                         ,ob.CodeValue
						 ,cte.CodeNames as DisplayVarients -- Display varients/result column..
						 ,cte.Comments 
						 , ob.CodeSystem
						 ,ob.Name 
						 ,ob.Value 
						 ,ob.ClinicalComments
                         ,ob.InternalComments
						 , ob.ModuleID
						 , ob.Status
						 , ob.CreatedOn, ob.CreatedBy, ob.UpdatedOn, ob.UpdatedBy, ob.DeletedOn, ob.DeletedBy, ob.ApprovedOn 
                         ,ob.ApprovedBy, ob.ReleasedOn, ob.ReleasedBy
						 , ob.AccessionNumber
						 , cte.GroupID 
						 ,grp.Name as GroupName
                         ,cte.DisplayOrder
FROM			dbo.AGSObservations AS ob 
	INNER JOIN	dbo.AGSPatients AS p ON p.PatientID = ob.PatientID
	inner join	cteGroupMember cte on ob.ObservationID = cte.ObservationID 
	INNER JOIN  dbo.AGSObservationGroups grp ON cte.GroupID = grp.GroupID
where ob.DeletedOn is null and grp.Category <> 1




GO
/****** Object:  View [dbo].[vw_ParticipantAttributes]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_ParticipantAttributes]
AS
SELECT DISTINCT TOP (100) PERCENT p.PatientID, a.AttributeID, a.AttributeName, a.Value
FROM            dbo.AGSPatients AS p INNER JOIN
                         dbo.AGSResultPatients AS rp ON rp.PatientID = p.PatientID INNER JOIN
                         dbo.AGSResultAttributes AS a ON a.MessageID = rp.MessageID
WHERE        (a.AttributeID IN
                             (SELECT        AttributeID
                               FROM            dbo.AGSAttributes
                               WHERE        (ParentID = 180)))
ORDER BY a.AttributeID
GO
/****** Object:  Table [dbo].[AGSPGxStage]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSPGxStage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DisplayDrugsLong] [varchar](53) NULL,
	[PatientID] [int] NOT NULL,
	[MRN] [varchar](255) NOT NULL,
	[ResultAttributeID] [int] NOT NULL,
	[MessageID] [int] NOT NULL,
	[AttributeID] [int] NOT NULL,
	[AttributeName] [varchar](80) NOT NULL,
	[ParentResultAttributeID] [int] NULL,
	[Drug] [nvarchar](max) NULL,
	[Gene] [nvarchar](max) NULL,
	[DiplotypeValue] [nvarchar](max) NULL,
	[Logic_Gene] [nvarchar](7) NULL,
	[Drugs] [nvarchar](21) NULL,
	[Gene_SNP] [varchar](14) NULL,
	[Component_Displayed_in_Epic] [varchar](60) NULL,
	[Diplotype] [nvarchar](25) NULL,
	[Display_Diplotype] [nvarchar](33) NULL,
	[Phenotype_Clinical_implication] [nvarchar](30) NULL,
	[Recommendations] [nvarchar](108) NULL,
	[Lab_Interpretation] [nvarchar](2276) NULL,
	[NU_Report_Drug_Response] [nvarchar](179) NULL,
	[NU_Report_Recommendation] [nvarchar](560) NULL,
	[NU_Summary_Drug_Gene_Interaction] [nvarchar](55) NULL,
	[Display_Order] [int] NULL,
 CONSTRAINT [PK_AGSPGxStage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[PatientID] ASC,
	[MRN] ASC,
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_PGx_SummaryReport]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE VIEW [dbo].[vw_PGx_SummaryReport]
AS

SELECT distinct g.GroupID, 
		g.Name as groupName, 
		gm.ObservationID, 
		c.MessageID,
		o.PatientID,
--		c.MRN, 
		o.Name as ObservationName,
		c.NU_Summary_Drug_Gene_Interaction,
		c.Gene,
		c.Display_Diplotype,
		c.NU_Report_Drug_Response,
		c.NU_Report_Recommendation,
		c.Recommendations, 
		o.Value, 
		o.ClinicalComments,
		o.InternalComments,
		o.CodeValue, 
		o.CodeName, 
		o.AbnormalFlag
FROM     dbo.AGSObservationGroups AS g 
	INNER JOIN dbo.AGSObservationGroupMembers AS gm ON g.GroupID = gm.GroupID 
	INNER JOIN dbo.AGSObservations AS o ON o.ObservationID = gm.ObservationID
	inner join [dbo].[AGSPGxStage] c on o.PatientID = c.PatientID and o.Name = c.[DisplayDrugsLong]
WHERE   (g.Name LIKE '%pgx%') and 
		gm.Status = 0


/*
with pgx212
as
(
select distinct a.* --, b.Value
  FROM [AGS].[dbo].[AGSResultAttributes] a
  where a.AttributeID in (212,214)
)
,Gene as
(
select distinct
	[ResultAttributeID]
      ,[MessageID]
      ,[AttributeID]
      ,[AttributeName]
      ,[ParentResultAttributeID]
	,i.Value as Gene
FROM [AGS].[dbo].[AGSResultAttributes] i
where  (i.AttributeID=162 and messageid in 
	(select MessageID from [AGSResultAttributes] o 
		where i.MessageID = o.MessageID and i.ParentResultAttributeID = o.ParentResultAttributeID))
 )
 ,Step2
 as
 (
 select distinct
	 a.[ResultAttributeID]
    ,a.[MessageID]
    ,a.[AttributeID]
    ,a.[AttributeName]
    ,a.[ParentResultAttributeID]
	,a.Value as Drug
	,b.Gene
	,(select i.Value
		FROM [AGS].[dbo].[AGSResultAttributes] i
		where i.AttributeID = 214 and a.MessageID = i.MessageID and i.ParentResultAttributeID = a.ParentResultAttributeID)  as DiplotypeValue
 from pgx212 a 
	inner join Gene b on a.MessageID = b.MessageID and a.ParentResultAttributeID = b.ParentResultAttributeID
 where a.AttributeID = 212
 )
 ,step4
 as
 (
 select distinct p.PatientID
	,pat.MRN
	,s.*
	,l.[Gene] as Logic_Gene
    ,l.[Drugs]
	,n.Gene_SNP
	,n.[Component_Displayed_in_Epic]
    ,l.[Diplotype]
	,l.[Display_Diplotype]
    ,l.[Phenotype_Clinical_implication]
    ,l.[Recommendations]
    ,l.[Lab_Interpretation]
    ,l.[NU_Report_Drug_Response]
    ,l.[NU_Report_Recommendation]
	,l.[NU_Summary_Drug_Gene_Interaction]
	,n.[Display_Order]
from Step2 s
 left join AGSPGx_Report_Logic l on s.Gene = l.[Gene] and s.DiplotypeValue = l.[Diplotype] and s.Drug = l.drugs
 left join [AGSNU_eMERGE_Seq] n on s.Gene = n.Gene_SNP  and upper(n.[Component_Displayed_in_Epic]) like upper(l.drugs) +'%' 
 inner join [AGSResultPatients] p on s.MessageID = p.MessageID 
 inner join AGSPatients pat on p.PatientID = pat.PatientID
 )
 ,cte
 as
 (
 select m.[DisplayDrugsLong],
	c.*
 from step4 c
 left join [dbo].[AGSPGx_Mappings] m on c.Gene = m.gene and c.Drugs = m.drugs
 )
SELECT distinct g.GroupID, 
		g.Name as groupName, 
		gm.ObservationID, 
		c.MessageID,
		o.PatientID,
--		c.MRN, 
		o.Name as ObservationName,
		c.NU_Summary_Drug_Gene_Interaction,
		c.Gene,
		c.Display_Diplotype,
		c.NU_Report_Drug_Response,
		c.NU_Report_Recommendation,
		c.Recommendations, 
		o.Value, 
		o.ClinicalComments,
		o.InternalComments,
		o.CodeValue, 
		o.CodeName, 
		o.AbnormalFlag
FROM     dbo.AGSObservationGroups AS g 
	INNER JOIN dbo.AGSObservationGroupMembers AS gm ON g.GroupID = gm.GroupID 
	INNER JOIN dbo.AGSObservations AS o ON o.ObservationID = gm.ObservationID
	inner join cte c on o.PatientID = c.PatientID and o.Name = c.[DisplayDrugsLong]
WHERE   (g.Name LIKE '%pgx%') and 
		gm.Status = 0

*/


GO
/****** Object:  View [dbo].[vw_ResultSamples]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ResultSamples] AS
SELECT 
  rm.MessageID 
  ,p.PatientId
  ,ra.AttributeID
  ,ra.AttributeName
  ,ra.Value
FROM AGSResultMessages rm 
JOIN AGSResultAttributes ra on (ra.[MessageID] = rm.[MessageID])
JOIN AGSResultPatients rp on (rm.MessageID = rp.MessageID)
JOIN AGSPatients p on (rp.[PatientID] = p.[PatientID])
WHERE 
  AttributeID in (
	SELECT AttributeID
	FROM [AGSAttributes] 
	WHERE ParentID = 20
  )
  
  
GO
/****** Object:  Table [dbo].[AGSAttributeDataTypes]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSAttributeDataTypes](
	[DataTypeID] [int] NOT NULL,
	[Name] [varchar](80) NOT NULL,
 CONSTRAINT [PK_AGSAttributeDataTypes] PRIMARY KEY CLUSTERED 
(
	[DataTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSAttributeTypes]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSAttributeTypes](
	[AttributeTypeID] [int] NOT NULL,
	[Name] [varchar](80) NOT NULL,
	[DataTypeID] [int] NOT NULL,
	[MaxLength] [int] NULL,
	[MinLength] [int] NULL,
	[JoinTable] [varchar](255) NULL,
	[JoinColumn] [varchar](255) NULL,
	[ValuePosition] [tinyint] NOT NULL,
 CONSTRAINT [PK_AGSAttributeTypes] PRIMARY KEY CLUSTERED 
(
	[AttributeTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSAuditLogs]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSAuditLogs](
	[AuditLogID] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Details] [nvarchar](1000) NULL,
	[ActionBy] [nvarchar](255) NOT NULL,
	[ActionOn] [datetime] NOT NULL,
 CONSTRAINT [PK_AGSAuditLogs] PRIMARY KEY CLUSTERED 
(
	[AuditLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSClinics]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSClinics](
	[ClinicID] [int] IDENTITY(1,1) NOT NULL,
	[Clinic] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSCommunicationTemplates]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSCommunicationTemplates](
	[TemplateId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[TemplateType] [tinyint] NOT NULL,
	[TemplateContent] [nvarchar](max) NOT NULL,
	[ContentType] [tinyint] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_AGSCommunicationTemplates] PRIMARY KEY CLUSTERED 
(
	[TemplateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSDocumentation]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSDocumentation](
	[DocumentationID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NOT NULL,
	[ParentType] [tinyint] NOT NULL,
	[OriginalFileName] [varchar](255) NOT NULL,
	[FilePath] [varchar](260) NOT NULL,
	[FileName] [varchar](255) NOT NULL,
	[Mimetype] [varchar](255) NOT NULL,
 CONSTRAINT [PK_AGSDocumentation] PRIMARY KEY CLUSTERED 
(
	[DocumentationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSDocumentation_Audits]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSDocumentation_Audits](
	[ResultMessageDocumentationAuditID] [int] IDENTITY(1,1) NOT NULL,
	[DocumentationID] [int] NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[AuditDate] [datetime] NOT NULL,
	[AuditType] [char](1) NOT NULL,
	[Field] [varchar](200) NOT NULL,
	[FromValue] [nvarchar](max) NULL,
	[ToValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AGSResultMessageDocumentation_Audit] PRIMARY KEY CLUSTERED 
(
	[ResultMessageDocumentationAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSFilterSettings]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSFilterSettings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[User] [varchar](300) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Value] [nvarchar](max) NULL,
	[DataType] [int] NOT NULL,
 CONSTRAINT [PK_AGSFilterSettings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSInterpretationTemplates]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSInterpretationTemplates](
	[TemplateID] [int] IDENTITY(1,1) NOT NULL,
	[TemplateKey] [varchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[TemplateText] [nvarchar](max) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [varchar](255) NULL,
 CONSTRAINT [PK_AGSInterpretationTemplate] PRIMARY KEY CLUSTERED 
(
	[TemplateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSLogicModules]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSLogicModules](
	[ModuleID] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Version] [varchar](50) NOT NULL,
	[Path] [varchar](255) NOT NULL,
	[Comments] [nvarchar](max) NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [varchar](255) NULL,
 CONSTRAINT [PK_AGSLogicModules] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSMappings]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSMappings](
	[MappingID] [int] IDENTITY(1,1) NOT NULL,
	[FromContext] [nvarchar](255) NOT NULL,
	[FromID] [nvarchar](255) NOT NULL,
	[ToContext] [nvarchar](255) NOT NULL,
	[ToID] [nvarchar](255) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AGSMappings] PRIMARY KEY CLUSTERED 
(
	[MappingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSNU_eMERGE_Seq]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSNU_eMERGE_Seq](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Component_Displayed_in_Epic] [varchar](60) NULL,
	[Display_Order] [int] NULL,
	[Meets_Epic_Guidelines] [varchar](2) NULL,
	[Gene_SNP] [varchar](14) NULL,
	[Category] [varchar](15) NULL,
	[Allowed_Values] [varchar](23) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_AGSNU_eMERGE_Seq] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSObservation_Audits]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSObservation_Audits](
	[ObservationAuditID] [int] IDENTITY(1,1) NOT NULL,
	[ObservationID] [int] NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[AuditDate] [datetime] NOT NULL,
	[AuditType] [char](1) NOT NULL,
	[Field] [varchar](200) NOT NULL,
	[FromValue] [nvarchar](max) NULL,
	[ToValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AGSObservation_Audits] PRIMARY KEY CLUSTERED 
(
	[ObservationAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSObservationDetails]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSObservationDetails](
	[DetailID] [int] IDENTITY(1,1) NOT NULL,
	[ObservationID] [int] NOT NULL,
	[Details] [nvarchar](max) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [varchar](255) NULL,
 CONSTRAINT [PK_AGSObservationDetails] PRIMARY KEY CLUSTERED 
(
	[DetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSObservationExportHistory]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSObservationExportHistory](
	[ExportID] [int] IDENTITY(1,1) NOT NULL,
	[ObservationID] [int] NOT NULL,
	[GroupID] [int] NULL,
	[ReleasedTo] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[ReleasedOn] [datetime] NOT NULL,
	[ReleasedBy] [varchar](255) NULL,
 CONSTRAINT [PK_AGSObservationExportHistory] PRIMARY KEY CLUSTERED 
(
	[ExportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSPatient_Audits]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSPatient_Audits](
	[PatientAuditID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[AuditDate] [datetime] NOT NULL,
	[AuditType] [char](1) NOT NULL,
	[Field] [varchar](200) NOT NULL,
	[FromValue] [nvarchar](max) NULL,
	[ToValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AGSResultPatient_Audits] PRIMARY KEY CLUSTERED 
(
	[PatientAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSPGx_Mappings]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSPGx_Mappings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Gene] [varchar](7) NULL,
	[Drugs] [varchar](21) NULL,
	[DisplayDrugsLong] [varchar](53) NULL,
	[DisplayDrugsShort] [varchar](60) NULL,
	[CodeValue] [varchar](50) NULL,
	[CodeName] [varchar](5000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSPGx_Report_Logic]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSPGx_Report_Logic](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Gene] [nvarchar](50) NULL,
	[Drugs] [nvarchar](255) NULL,
	[Display_Drugs] [nvarchar](255) NULL,
	[Diplotype] [nvarchar](255) NULL,
	[Phenotype_Clinical_implication] [nvarchar](255) NULL,
	[Recommendations] [nvarchar](255) NULL,
	[Lab_Interpretation] [nvarchar](2500) NULL,
	[Display_Diplotype] [nvarchar](255) NULL,
	[NU_Report_Drug_Response] [nvarchar](500) NULL,
	[NU_Report_Recommendation] [nvarchar](1000) NULL,
	[NU_Summary_Drug_Gene_Interaction] [nvarchar](255) NULL,
	[NU_Summary_Drug_Gene_Interaction_Printed] [nvarchar](255) NULL,
	[IsActive] [bit] NULL,
	[SortOrder] [tinyint] NULL,
 CONSTRAINT [PK_AGSPGx_Report_Logic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSResultMessage_Audits]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSResultMessage_Audits](
	[ResultMessageAuditID] [int] IDENTITY(1,1) NOT NULL,
	[MessageID] [int] NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[AuditDate] [datetime] NOT NULL,
	[AuditType] [char](1) NOT NULL,
	[Field] [varchar](200) NOT NULL,
	[FromValue] [nvarchar](max) NULL,
	[ToValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AGSResultMessages_Audit] PRIMARY KEY CLUSTERED 
(
	[ResultMessageAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSResultTypes]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSResultTypes](
	[ResultTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ResultType] [varchar](50) NULL,
 CONSTRAINT [PK_AGSResultTypes] PRIMARY KEY CLUSTERED 
(
	[ResultTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSVariantAttributes]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSVariantAttributes](
	[VariantAttributeID] [int] IDENTITY(1,1) NOT NULL,
	[VariantID] [int] NOT NULL,
	[CodeSystem] [nvarchar](255) NOT NULL,
	[CodeName] [nvarchar](255) NOT NULL,
	[CodeValue] [nvarchar](255) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_AGSVariantAttributes] PRIMARY KEY CLUSTERED 
(
	[VariantAttributeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGSVariants]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGSVariants](
	[VariantID] [int] IDENTITY(1,1) NOT NULL,
	[Context] [nvarchar](50) NULL,
	[Type] [tinyint] NOT NULL,
	[Value] [nvarchar](50) NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_AGSVariants] PRIMARY KEY CLUSTERED 
(
	[VariantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AGSInterpretationTemplates_TemplateKeyAndStatus]    Script Date: 4/15/2020 2:24:15 PM ******/
CREATE NONCLUSTERED INDEX [IX_AGSInterpretationTemplates_TemplateKeyAndStatus] ON [dbo].[AGSInterpretationTemplates]
(
	[TemplateKey] ASC,
	[Status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AGSVariantAttributes_VariantID]    Script Date: 4/15/2020 2:24:15 PM ******/
CREATE NONCLUSTERED INDEX [IX_AGSVariantAttributes_VariantID] ON [dbo].[AGSVariantAttributes]
(
	[VariantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AGSVariants_Context_Type_Value]    Script Date: 4/15/2020 2:24:15 PM ******/
CREATE NONCLUSTERED INDEX [IX_AGSVariants_Context_Type_Value] ON [dbo].[AGSVariants]
(
	[Context] ASC,
	[Type] ASC,
	[Value] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AGSAttributes] ADD  CONSTRAINT [DF_AGSAttributes_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[AGSPatientCTMSData] ADD  CONSTRAINT [DF_AGSPatientCTMSData_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[AGSAttributes]  WITH CHECK ADD  CONSTRAINT [FK_AGSAttributes_AGSAttributeTypes] FOREIGN KEY([AttributeTypeID])
REFERENCES [dbo].[AGSAttributeTypes] ([AttributeTypeID])
GO
ALTER TABLE [dbo].[AGSAttributes] CHECK CONSTRAINT [FK_AGSAttributes_AGSAttributeTypes]
GO
ALTER TABLE [dbo].[AGSAttributeTypes]  WITH CHECK ADD  CONSTRAINT [FK_AGSAttributeTypes_AGSAttributeDataTypes] FOREIGN KEY([DataTypeID])
REFERENCES [dbo].[AGSAttributeDataTypes] ([DataTypeID])
GO
ALTER TABLE [dbo].[AGSAttributeTypes] CHECK CONSTRAINT [FK_AGSAttributeTypes_AGSAttributeDataTypes]
GO
ALTER TABLE [dbo].[AGSCommunications]  WITH CHECK ADD  CONSTRAINT [FK_AGSCommunications_AGSCommunicationTemplates] FOREIGN KEY([TemplateId])
REFERENCES [dbo].[AGSCommunicationTemplates] ([TemplateId])
GO
ALTER TABLE [dbo].[AGSCommunications] CHECK CONSTRAINT [FK_AGSCommunications_AGSCommunicationTemplates]
GO
ALTER TABLE [dbo].[AGSCommunications]  WITH CHECK ADD  CONSTRAINT [FK_AGSObservationGroups_AGSCommunications] FOREIGN KEY([ObservationGroupID])
REFERENCES [dbo].[AGSObservationGroups] ([GroupID])
GO
ALTER TABLE [dbo].[AGSCommunications] CHECK CONSTRAINT [FK_AGSObservationGroups_AGSCommunications]
GO
ALTER TABLE [dbo].[AGSDocumentation_Audits]  WITH CHECK ADD  CONSTRAINT [FK_AGSDocumentation_Audits_AGSDocumentation] FOREIGN KEY([DocumentationID])
REFERENCES [dbo].[AGSDocumentation] ([DocumentationID])
GO
ALTER TABLE [dbo].[AGSDocumentation_Audits] CHECK CONSTRAINT [FK_AGSDocumentation_Audits_AGSDocumentation]
GO
ALTER TABLE [dbo].[AGSObservationDetails]  WITH CHECK ADD  CONSTRAINT [FK_AGSObservationDetails_AGSObservations] FOREIGN KEY([ObservationID])
REFERENCES [dbo].[AGSObservations] ([ObservationID])
GO
ALTER TABLE [dbo].[AGSObservationDetails] CHECK CONSTRAINT [FK_AGSObservationDetails_AGSObservations]
GO
ALTER TABLE [dbo].[AGSObservationExportHistory]  WITH CHECK ADD  CONSTRAINT [FK_AGSObservationExportHistory_AGSObservationGroups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[AGSObservationGroups] ([GroupID])
GO
ALTER TABLE [dbo].[AGSObservationExportHistory] CHECK CONSTRAINT [FK_AGSObservationExportHistory_AGSObservationGroups]
GO
ALTER TABLE [dbo].[AGSObservationExportHistory]  WITH CHECK ADD  CONSTRAINT [FK_AGSObservationExportHistory_AGSObservations] FOREIGN KEY([ObservationID])
REFERENCES [dbo].[AGSObservations] ([ObservationID])
GO
ALTER TABLE [dbo].[AGSObservationExportHistory] CHECK CONSTRAINT [FK_AGSObservationExportHistory_AGSObservations]
GO
ALTER TABLE [dbo].[AGSObservationGroupMembers]  WITH CHECK ADD  CONSTRAINT [FK_AGSObservationGroupMembers_AGSObservationGroups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[AGSObservationGroups] ([GroupID])
GO
ALTER TABLE [dbo].[AGSObservationGroupMembers] CHECK CONSTRAINT [FK_AGSObservationGroupMembers_AGSObservationGroups]
GO
ALTER TABLE [dbo].[AGSObservationGroupMembers]  WITH CHECK ADD  CONSTRAINT [FK_AGSObservationGroupMembers_AGSObservations] FOREIGN KEY([ObservationID])
REFERENCES [dbo].[AGSObservations] ([ObservationID])
GO
ALTER TABLE [dbo].[AGSObservationGroupMembers] CHECK CONSTRAINT [FK_AGSObservationGroupMembers_AGSObservations]
GO
ALTER TABLE [dbo].[AGSObservationResultAttributes]  WITH CHECK ADD  CONSTRAINT [FK_AGSObservationResultAttributes_AGSObservations] FOREIGN KEY([ObservationID])
REFERENCES [dbo].[AGSObservations] ([ObservationID])
GO
ALTER TABLE [dbo].[AGSObservationResultAttributes] CHECK CONSTRAINT [FK_AGSObservationResultAttributes_AGSObservations]
GO
ALTER TABLE [dbo].[AGSObservationResultAttributes]  WITH CHECK ADD  CONSTRAINT [FK_AGSObservationResultAttributes_AGSResultAttributes] FOREIGN KEY([ResultAttributeID])
REFERENCES [dbo].[AGSResultAttributes] ([ResultAttributeID])
GO
ALTER TABLE [dbo].[AGSObservationResultAttributes] CHECK CONSTRAINT [FK_AGSObservationResultAttributes_AGSResultAttributes]
GO
ALTER TABLE [dbo].[AGSObservations]  WITH CHECK ADD  CONSTRAINT [FK_AGSObservations_AGSPatients] FOREIGN KEY([PatientID])
REFERENCES [dbo].[AGSPatients] ([PatientID])
GO
ALTER TABLE [dbo].[AGSObservations] CHECK CONSTRAINT [FK_AGSObservations_AGSPatients]
GO
ALTER TABLE [dbo].[AGSPatient_Audits]  WITH CHECK ADD  CONSTRAINT [FK_AGSPatient_Audits_AGSPatients] FOREIGN KEY([PatientID])
REFERENCES [dbo].[AGSPatients] ([PatientID])
GO
ALTER TABLE [dbo].[AGSPatient_Audits] CHECK CONSTRAINT [FK_AGSPatient_Audits_AGSPatients]
GO
ALTER TABLE [dbo].[AGSResultAttributes]  WITH CHECK ADD  CONSTRAINT [FK_AGSResultAttributes_AGSAttributes] FOREIGN KEY([AttributeID])
REFERENCES [dbo].[AGSAttributes] ([AttributeID])
GO
ALTER TABLE [dbo].[AGSResultAttributes] CHECK CONSTRAINT [FK_AGSResultAttributes_AGSAttributes]
GO
ALTER TABLE [dbo].[AGSResultAttributes]  WITH CHECK ADD  CONSTRAINT [FK_AGSResultAttributes_AGSResultMessages] FOREIGN KEY([MessageID])
REFERENCES [dbo].[AGSResultMessages] ([MessageID])
GO
ALTER TABLE [dbo].[AGSResultAttributes] CHECK CONSTRAINT [FK_AGSResultAttributes_AGSResultMessages]
GO
ALTER TABLE [dbo].[AGSResultMessage_Audits]  WITH CHECK ADD  CONSTRAINT [FK_AGSResultMessages_Audit_AGSResultMessages] FOREIGN KEY([MessageID])
REFERENCES [dbo].[AGSResultMessages] ([MessageID])
GO
ALTER TABLE [dbo].[AGSResultMessage_Audits] CHECK CONSTRAINT [FK_AGSResultMessages_Audit_AGSResultMessages]
GO
ALTER TABLE [dbo].[AGSResultMessageFiles]  WITH CHECK ADD  CONSTRAINT [FK_AGSResultMessageFiles_AGSResultMessageFileTypes] FOREIGN KEY([MessageFileTypeID])
REFERENCES [dbo].[AGSResultMessageFileTypes] ([MessageFileTypeID])
GO
ALTER TABLE [dbo].[AGSResultMessageFiles] CHECK CONSTRAINT [FK_AGSResultMessageFiles_AGSResultMessageFileTypes]
GO
ALTER TABLE [dbo].[AGSResultMessageFiles]  WITH CHECK ADD  CONSTRAINT [FK_AGSResultMessageFiles_AGSResultMessages] FOREIGN KEY([MessageID])
REFERENCES [dbo].[AGSResultMessages] ([MessageID])
GO
ALTER TABLE [dbo].[AGSResultMessageFiles] CHECK CONSTRAINT [FK_AGSResultMessageFiles_AGSResultMessages]
GO
ALTER TABLE [dbo].[AGSResultPatients]  WITH CHECK ADD  CONSTRAINT [FK_AGSResultPatients_AGSPatients] FOREIGN KEY([PatientID])
REFERENCES [dbo].[AGSPatients] ([PatientID])
GO
ALTER TABLE [dbo].[AGSResultPatients] CHECK CONSTRAINT [FK_AGSResultPatients_AGSPatients]
GO
ALTER TABLE [dbo].[AGSResultPatients]  WITH CHECK ADD  CONSTRAINT [FK_AGSResultPatients_AGSResultMessages] FOREIGN KEY([MessageID])
REFERENCES [dbo].[AGSResultMessages] ([MessageID])
GO
ALTER TABLE [dbo].[AGSResultPatients] CHECK CONSTRAINT [FK_AGSResultPatients_AGSResultMessages]
GO
ALTER TABLE [dbo].[AGSVariantAttributes]  WITH CHECK ADD  CONSTRAINT [FK_AGSVariantAttributes_AGSVariants] FOREIGN KEY([VariantID])
REFERENCES [dbo].[AGSVariants] ([VariantID])
GO
ALTER TABLE [dbo].[AGSVariantAttributes] CHECK CONSTRAINT [FK_AGSVariantAttributes_AGSVariants]
GO
/****** Object:  StoredProcedure [dbo].[spGetAGSAttributeHierarchy]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	    Luke Rasmussen
-- Create date: August 24, 2013
-- Description:	Retrieves all descendant attributes
--    for a given attribute in the Ancillary Genomic
--    System's attribute dictionary.
-- =============================================
CREATE PROCEDURE [dbo].[spGetAGSAttributeHierarchy]
	@AttributeID [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    ;WITH Attributes ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) AS
    (
        SELECT [AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn] 
        FROM dbo.AGSAttributes
        WHERE AttributeID = @AttributeID
        
        UNION ALL
        
        SELECT ChildAttr.[AttributeID], ChildAttr.[Name], ChildAttr.[ParentID], ChildAttr.[Description], ChildAttr.[AttributeTypeID], ChildAttr.[CreatedOn], ChildAttr.[Status], ChildAttr.[DeletedOn]
        FROM dbo.AGSAttributes ChildAttr
            INNER JOIN Attributes ON Attributes.AttributeID = ChildAttr.ParentID
    )

    SELECT * FROM Attributes
    WHERE AttributeTypeID != 1 -- Ignore abstract entities
        AND [Status] = 1 -- Active attributes only

END
GO
/****** Object:  StoredProcedure [dbo].[spPopulateCTMsTable]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sameem Samad
-- Create date: 2/4/19
-- Description:	Populate CMTs table
-- =============================================

-- Exec spPopulateCTMsTable
CREATE PROCEDURE [dbo].[spPopulateCTMsTable] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	truncate table [AGSPatientCTMSData]

insert into [AGSPatientCTMSData](PatientID,MessageID,StudyID,IndicationForTesting,DiseaseStatus,HasPreviouslyKnownMutations,PreviouslyKnownMutations)
SELECT PatientID, MessageID,
          MAX(CASE WHEN [AttributeID] = 181 THEN [Value] END) AS StudyID,
          MAX(CASE WHEN [AttributeID] = 183 THEN [Value] END) AS IndicationForTesting,
          MAX(CASE WHEN [AttributeID] = 184 THEN [Value] END) AS DiseaseStatus,
          MAX(CASE WHEN [AttributeID] = 185 THEN [Value] END) AS HasPreviouslyKnownMutations,
          MAX(CASE WHEN [AttributeID] = 186 THEN [Value] END) AS PreviouslyKnownMutations
FROM (
SELECT *
FROM dbo.AGSResultAttributes ra
INNER JOIN (
          select PatientID, MAX(rp.MessageID) AS StudyTrackerMessageID from dbo.AGSResultMessages rm
                   inner join dbo.AGSResultPatients rp ON rp.MessageID = rm.MessageID
          WHERE Sender = 'CDSI' AND [Status] = 'Received'
          GROUP BY PatientID
) AS msg
ON msg.StudyTrackerMessageID = ra.MessageID
) [attributes]
GROUP BY PatientID, MessageID


END

GO
/****** Object:  StoredProcedure [dbo].[spStudyTrackerDataCleanUp]    Script Date: 4/15/2020 2:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sameem Samad
-- Create date: 
-- Description:	Cleans up the data and repopulate the CTMs table
-- =============================================
CREATE PROCEDURE [dbo].[spStudyTrackerDataCleanUp] 
AS
BEGIN

	DECLARE @trancount int;
	SET @trancount = @@TRANCOUNT;

	BEGIN TRY
		IF @trancount = 0
				BEGIN TRANSACTION
		ELSE
			BEGIN
			RAISERROR('Expected 0 transactions, but found %d', 16, 1, @trancount)
			RETURN;
			END
   
		-- Find all patients that have more than one preferences message, and locate the most
		-- recent message ID (which we are assuming is the one to keep).
		DECLARE @PatientsWithDuplicateSettings TABLE
		(
			PatientID int,
			SettingsMessageToKeep int
		)
		INSERT INTO @PatientsWithDuplicateSettings
		select PatientID, MAX(rp.MessageID) from dbo.AGSResultMessages rm
			inner join dbo.AGSResultPatients rp ON rp.MessageID = rm.MessageID
		WHERE Sender = 'CDSI'
		GROUP BY PatientID
		HAVING COUNT(rm.MessageID) > 1

		-- Build the list of message IDs that we want to delete
		DECLARE @MessagesToDelete TABLE
		(
			MessageID int
		)
		INSERT INTO @MessagesToDelete
		SELECT rm.MessageID from dbo.AGSResultMessages rm
			inner join dbo.AGSResultPatients rp ON rp.MessageID = rm.MessageID
			INNER JOIN @PatientsWithDuplicateSettings pds ON pds.PatientID = rp.patientID AND pds.SettingsMessageToKeep != rp.MessageID
		WHERE rm.Sender = 'CDSI'

		-- Perform the actual delete of related records
		DELETE FROM dbo.AGSResultAttributes WHERE MessageID IN (select * from @MessagesToDelete)
		DELETE FROM dbo.AGSResultPatients WHERE MessageID IN (select * from @MessagesToDelete)
		DELETE FROM dbo.AGSResultMessageFiles WHERE MessageID IN (select * from @MessagesToDelete)
		DELETE FROM dbo.AGSResultMessages WHERE MessageID IN (select * from @MessagesToDelete)
		COMMIT;
	END TRY
	BEGIN CATCH
		DECLARE @error INT, @message VARCHAR(4000), @xstate INT;
		SELECT @error = ERROR_NUMBER(), @message = ERROR_MESSAGE(), @xstate = XACT_STATE();
		-- There is a transaction but it can't be committed, so roll it back
		IF @xstate = -1
			ROLLBACK;
		-- If there is a commitable transaction, and it's ours (@trancount should have been 0
		-- when we started), we need to roll it back.
		IF @xstate = 1 and @trancount = 0
			ROLLBACK;

		RAISERROR ('Error in running cleanup script: %d: %s', 16, 1, @error, @message) ;
		RETURN;
	END CATCH
		
	-- Repopulate the CTMs table
	exec [dbo].[spPopulateCTMsTable]

END

GO



INSERT [dbo].[AGSAttributeDataTypes] ([DataTypeID], [Name]) VALUES (1, N'Generic Value')
GO
INSERT [dbo].[AGSAttributeTypes] ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES (1, N'Abstract Entity', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[AGSAttributeTypes] ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES (2, N'Haplotype Star Variant', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[AGSAttributeTypes] ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES (3, N'Diplotype Star Variant', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[AGSAttributeTypes] ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES (4, N'Allele Value', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[AGSAttributeTypes] ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES (5, N'Genotype (SNP) Value', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[AGSAttributeTypes] ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES (6, N'Value Observation', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[AGSAttributeTypes] ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES (7, N'Laboratory Sample', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[AGSAttributeTypes] ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES (8, N'Controlled Vocabulary Code', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[AGSAttributeTypes] ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES (9, N'Form Response', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (1, N'Value Derivation', 0, N'', 1, CAST(N'2013-08-23T14:22:54.280' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (20, N'Sample', 0, N'Laboratory Sample', 7, CAST(N'2013-08-23T14:22:54.280' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (21, N'Unassigned', 20, N'Unassigned Attribute', 6, CAST(N'2013-08-23T14:22:54.283' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (22, N'Sample Type', 20, N'Type of Laboratory Sample', 1, CAST(N'2013-08-23T14:22:54.283' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (23, N'Signed By', 20, N'Who signed the results', 1, CAST(N'2013-08-23T14:22:54.283' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (24, N'Created On', 20, N'Sample record created on date', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (25, N'Observed On', 20, N'Sample observed on date', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (26, N'Patient ID', 20, N'Patient Id of sample', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (27, N'Status', 20, N'Status of the sample', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (28, N'Comments', 20, N'Sample Comments', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (29, N'RecievedOn', 20, N'Sample is received by the processing laboratory on date', 1, CAST(N'2013-08-23T00:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (100, N'Genetic Result', 0, N'', 1, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (101, N'CYP2C9 Result', 100, N'', 1, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (102, N'CYP2C9 Haplotype #1', 101, N'', 2, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (103, N'CYP2C9 Haplotype #2', 101, N'', 2, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (104, N'CYP2C9 Genotype', 101, N'', 3, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (105, N'CYP2C9 Fail', 101, N'', 1, CAST(N'2013-08-23T14:22:54.293' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (106, N'VKORC1 Result', 100, N'', 1, CAST(N'2013-08-23T14:22:54.293' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (107, N'VKORC1 Allele #1', 106, N'', 4, CAST(N'2013-08-23T14:22:54.293' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (108, N'VKORC1 Allele #2', 106, N'', 4, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (109, N'VKORC1 Genotype', 106, N'', 5, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (110, N'VKORC1 Fail', 106, N'', 1, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (111, N'CYP2C19 Result', 100, N'', 1, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (112, N'CYP2C19 Haplotype #1', 111, N'', 2, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (113, N'CYP2C19 Haplotype #2', 111, N'', 2, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (114, N'CYP2C19 Genotype', 111, N'', 3, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (115, N'CYP2C19 Fail', 111, N'', 1, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (116, N'CYP2C19 SNP', 111, N'', 1, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (117, N'rs12248560', 116, N'', 5, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (118, N'rs28399504', 116, N'', 5, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (119, N'rs41291556', 116, N'', 5, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (120, N'SLCO1B1 Result', 100, N'', 1, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (121, N'SLCO1B1 Allele #1', 120, N'', 4, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (122, N'SLCO1B1 Allele #2', 120, N'', 4, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (123, N'SLCO1B1 Genotype', 120, N'', 5, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (124, N'SLCO1B1 Fail', 120, N'', 1, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (125, N'rs72552267', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (126, N'rs4986893', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (127, N'rs4244285', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (128, N'rs72558186', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (129, N'rs56337013', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (130, N'CYP2C9 SNP', 101, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (131, N'rs1799853', 130, N'CYP2C9 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (132, N'rs9332131', 130, N'CYP2C9 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (133, N'rs1057910', 130, N'CYP2C9 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (134, N'rs28371686', 130, N'CYP2C9 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (135, N'VKORC1 SNP', 106, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (136, N'rs9923231', 135, N'VKORC1 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (137, N'rs7294', 135, N'VKORC1 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (138, N'rs9934438', 135, N'VKORC1 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (139, N'TPMT Result', 100, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (140, N'TPMT SNP', 139, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (141, N'rs1142345', 140, N'TPMT SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (142, N'rs1800462', 140, N'TPMT SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (143, N'CYP3A5 Result', 100, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (144, N'CYP3A5 SNP', 143, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (145, N'rs776746', 144, N'CYP3A5 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (146, N'Genotype Method', 100, N'How the genotype was derived', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (147, N'Method Description', 100, N'Narrative of the method used', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (148, N'Analytic Sensitivity', 100, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (149, N'rs4149056', 120, N'SLCO1B1 SNP', 5, CAST(N'2014-09-12T13:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (150, N'Institution', 20, N'The institution the results are intended for', 1, CAST(N'2015-05-11T08:54:28.820' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (151, N'Lab Identifier', 20, N'Internal identifier used by the laboratory for the sample', 1, CAST(N'2015-05-11T08:54:28.823' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (152, N'Tested On', 20, N'The date the laboratory performed the test', 1, CAST(N'2015-05-11T08:54:28.823' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (153, N'Turn Around from Date Received', 20, N'The turn around time (in days) from when the sample was received to results', 1, CAST(N'2015-05-11T08:54:28.823' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (154, N'Turn Around from Test Initiation', 20, N'The turn around time (in days) from when the test was initiated to results', 1, CAST(N'2015-05-11T08:54:28.823' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (155, N'Lab Accession', 20, N'', 1, CAST(N'2017-10-11T11:08:36.493' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (156, N'Test Indication', 20, N'', 1, CAST(N'2017-10-11T11:08:36.500' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (157, N'Overall Interpretation', 20, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (158, N'Reported variant', 20, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (159, N'Gene Region', 158, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (160, N'DNA Change', 158, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (161, N'Amino Acid Change', 158, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (162, N'Gene Symbol', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (163, N'Allele State', 158, N'', 8, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (164, N'Clinical Significance', 158, N'', 8, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (165, N'Transcript ID', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (166, N'Chromosome', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (167, N'Confirmed by Sanger', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (168, N'Category Type', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (169, N'Inheritance', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (170, N'Interpretation Text', 158, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (171, N'Associated Disease', 158, N'', 8, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (172, N'Reference Alignment', 158, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (173, N'Genome Build', 172, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (174, N'Start Position', 172, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (175, N'Wildtype Sequence', 172, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (176, N'Variant Sequence', 172, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (177, N'Addendum', 158, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (178, N'Addendum Text', 177, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (179, N'Addendum Date', 177, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (180, N'eMERGE III Participant Data', 0, N'Collection of data for each eMERGE 3 participant', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (181, N'Return of Result ID', 180, N'', 9, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (182, N'Study Status', 180, N'The current status of the participant on the study', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (183, N'Indication for Testing', 180, N'The indication for why the patient was selected to participate in eMERGE III', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (184, N'Disease Status', 180, N'The patient''s affected status of disease related to their indication for testing.', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (185, N'Has Previously Known Mutations', 180, N'Does the patient have one or more previously known mutations?', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (186, N'Previously Known Mutations', 180, N'The previously known mutations (if any)', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (187, N'Recruitment Clinic', 180, N'Where the participant was recruited from for the eMERGE III study', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (188, N'eMERGE III Options Arm', 180, N'Is the participant randomized to the study arm that selects options for return of results?', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (189, N'Option - Treatment IS Available', 180, N'Does the participant want to receive results where treatment is available?', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (190, N'Option - Treatment IS NOT Available', 180, N'Does the participant want to receive results where treatment is not available?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (191, N'Option - Dementia', 180, N'Does the participant want to receive results related to dementia?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (192, N'Option - Cancer', 180, N'Does the participant want to receive results related to cancer?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (193, N'Option - Behavior/Learning Conditions', 180, N'Does the participant want to receive results related to behavior/learning conditions?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (194, N'Option - Carrier', 180, N'Does the participant want to receive results about being a carrier?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (195, N'Option - Uncertain Results', 180, N'Does the participant want to receive results where our knowledge is uncertain on its interpretation?', 9, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (196, N'Code Value', 0, N'', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (197, N'Code System', 0, N'', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (198, N'HGSC VIP File', 20, N'HGSC (Baylor) VIP file identifier', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (199, N'Gene Coverage Entry', 20, N'Gene coverage result', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (200, N'Gene Coverage Value', 199, N'The coverage value for the gene', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (201, N'Assay Version', 20, N'External identifier of the assay version that produced the results', 1, CAST(N'2017-10-11T11:08:36.523' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (202, N'Assay Test Code', 20, N'Identifier for the assay that produced the results', 1, CAST(N'2017-10-11T11:08:36.523' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (203, N'Collection Date', 20, N'The date the sample was collected', 1, CAST(N'2017-10-11T11:08:36.523' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (204, N'Participant Address', 180, N'The mailing address on record for the participant', 9, CAST(N'2017-10-11T11:08:36.527' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (205, N'Appointment Location', 180, N'The appointment location where the recruitment took place', 9, CAST(N'2017-10-11T11:08:36.527' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (206, N'Participant Notes', 180, N'Free-text notes collected in the process of recruiting and enrolling the participant in the study', 9, CAST(N'2017-10-11T11:08:36.530' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (207, N'CNV Analysis Failed', 20, N'Indication from the sequencing center if the CNV analysis failed', 1, CAST(N'2018-04-05T12:35:18.897' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (208, N'Variant Interpretation', 158, N'An interpretation of a variant, which is associated with a reported variant', 1, CAST(N'2018-04-05T12:35:18.897' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (209, N'Report DNA Change', 158, N'A representation of the DNA change in HGNV format', 1, CAST(N'2018-04-05T12:35:18.900' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (210, N'PGx Comments', 20, N'PGx Comments', 1, CAST(N'2019-04-10T09:31:53.130' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (211, N'PGx Result', 20, N'PGx Result', 1, CAST(N'2019-04-10T09:32:40.427' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (212, N'PGx Associated Medication', 211, N'PGx Associated Medication', 1, CAST(N'2019-04-10T09:33:56.440' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (213, N'PGx Associated Recommendation', 211, N'PGx Associated Recommendation', 1, CAST(N'2019-04-10T09:33:56.440' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (214, N'PGx Diplotype', 211, N'PGx Diplotype', 3, CAST(N'2019-04-10T09:35:16.580' AS DateTime), 1, NULL)
GO
INSERT [dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES (215, N'PGx Phenotype', 211, N'PGx Phenotype', 1, CAST(N'2019-04-10T09:35:16.580' AS DateTime), 1, NULL)
GO

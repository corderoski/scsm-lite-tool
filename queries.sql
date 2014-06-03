

SELECT [ManagementPackId]
      ,[MPIsSealed]
      ,[MPName]
      ,[MPFriendlyName]
      ,[MPVersionDependentId]
      ,[MPVersion]
      ,[MPKeyToken]
      ,[MPReadOnly]
      ,[MPXMLInvalid]
      ,[MPLastModified]
      ,[MPCreated]
      ,[MPXML]
      ,[MPSchemaTypes]
      ,[MPRunTimeXML]
      ,[MPCacheRefreshTimestamp]
      ,[ContentReadable]
  FROM [ServiceManager].[dbo].[ManagementPack]
  WHERE [ManagementPackId] = '904BE494-1F7E-34C2-C192-59026EFC1457'
  
SELECT *
  FROM [ServiceManager].[dbo].[EnumType]
  
  
  SELECT *
  FROM [ServiceManager].[dbo].[ManagedTypeProperty]
  where EnumTypeId = '1F77F0CE-9E43-340F-1FD5-B11CC36C9CBA'
  
  SELECT  [BaseManagedEntityId]
      ,[BaseManagedEntityInternalId]
      ,[BaseManagedTypeId]
      ,[FullName]
      ,[Path]
      ,[Name]
      ,[DisplayName]
      ,[TopLevelHostEntityId]
      ,[IsDeleted]
      ,[LastModified]
      ,[OverrideTimestamp]
      ,[TimeAdded]
      ,[LastModifiedBy]
  FROM [ServiceManager].[dbo].[BaseManagedEntity]
  WHERE [BaseManagedEntityId] = '90D52B0B-BFF0-62E8-BBB9-CDD0D152887E'
  
  SELECT *
  FROM [ServiceManager].[dbo].[MT_ClassExtension_3290d3cc_2768_4cec_8aea_3a3ba992fde0]
  WHERE BaseManagedEntityId = '9039AEC8-9FF8-1141-BA62-5F9E4BB72B5D'
  
  SELECT wk.[BaseManagedEntityId]
      ,[Title_9691DD10_7211_C835_E3E7_6B38AF8B8104]
      ,[CreatedDate_6258638D_B885_AB3C_E316_D00782B8F688]
      ,TargetResolutionTime_52562B0E_55A7_4FB1_2F9C_FDFDE976823E
      ,ce.Categoria_14E66215_E15C_7E05_59C0_2162BF592DA1
      ,[DisplayName]
  FROM [ServiceManager].[dbo].[MT_System$WorkItem$Incident] wk
  LEFT JOIN [MT_ClassExtension_3290d3cc_2768_4cec_8aea_3a3ba992fde0] ce ON wk.BaseManagedEntityId = ce.BaseManagedEntityId
  ORDER BY [CreatedDate_6258638D_B885_AB3C_E316_D00782B8F688]
 
  
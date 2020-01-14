CREATE VIEW [Electric_Balancing].[FlowSettings_View]
	AS
	SELECT *
	FROM [$(BalancingDB)].dbo.FlowSettings_View

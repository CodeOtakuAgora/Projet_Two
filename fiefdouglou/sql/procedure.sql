USE [fiefdouglou];
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MatosPerimer]
AS
BEGIN
	SELECT * FROM Materiel WHERE DATEADD(DAY, -mtbf, date_intervention_faite)
	<= GETDATE()
END;

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MatosFonctionnel]
AS
BEGIN
	SELECT * FROM Materiel WHERE DATEADD(DAY, -mtbf, date_intervention_faite)
	>= GETDATE()
END;
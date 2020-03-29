USE [fiefdouglou];
GO

/****** Object:  StoredProcedure [dbo].[MatosFonctionnel]    Script Date: 29/03/2020 17:27:02 ******/
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
GO

/****** Object:  StoredProcedure [dbo].[MatosPerimer]    Script Date: 29/03/2020 17:27:02 ******/
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

/****** Object:  StoredProcedure [dbo].[NextIntervention]    Script Date: 29/03/2020 17:27:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NextIntervention]
AS
BEGIN
	SELECT * FROM intervention WHERE date_intervention >= GETDATE();
END;
GO

/****** Object:  StoredProcedure [dbo].[PrevIntervention]    Script Date: 29/03/2020 17:27:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrevIntervention]
AS
BEGIN
	SELECT * FROM intervention WHERE date_intervention <= GETDATE();
END;
GO
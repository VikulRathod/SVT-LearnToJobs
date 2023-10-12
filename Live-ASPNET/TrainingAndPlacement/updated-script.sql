--create database TrainingAndPlacement
--go
--use TrainingAndPlacement


GO
CREATE TABLE [dbo].[Add_Achievement](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[studentID] [nvarchar](50) NULL,
	[Achievement_Title] [nvarchar](50) NULL,
	[Achievement_Details] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL
)
 
GO
CREATE TABLE [dbo].[add_event](
	[event_id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[subject] [varchar](max) NULL,
	[body] [varchar](max) NULL
	)

GO
CREATE TABLE [dbo].[Add_Student_Activity](
	[Student_id] [int] NOT NULL,
	[Activity_Title] [nvarchar](100) NULL,
	[Activity_Details] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL
)
GO
CREATE TABLE [dbo].[Add_Technical_Deatils](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[stuID] [nvarchar](10) NULL,
	[Course_Title] [nvarchar](50) NULL,
	[Technical_Details] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL
	)

GO
CREATE TABLE [dbo].[Add_Total_Marks](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Academic_Year] [nvarchar](50) NULL,
	[First_Year_Marks] [nvarchar](50) NULL,
	[Second_Year_Marks] [nvarchar](50) NULL,
	[Third_Year_Marks] [nvarchar](50) NULL,
	[Fourth_Year_Marks] [nvarchar](50) NULL,
	[Fifth_Year_Marks] [nvarchar](50) NULL,
	[Sem_1_Marks] [nvarchar](50) NULL,
	[Sem_2_Marks] [nvarchar](50) NULL,
	[Sem_3_Marks] [nvarchar](50) NULL,
	[Sem_4_Marks] [nvarchar](50) NULL,
	[Sem_5_Marks] [nvarchar](50) NULL,
	[Sem_6_Marks] [nvarchar](50) NULL,
	[Sem_7_Marks] [nvarchar](50) NULL,
	[Sem_8_Marks] [nvarchar](50) NULL,
	[Sem_9_Marks] [nvarchar](50) NULL,
	[Sem_10_Marks] [nvarchar](50) NULL
	)

GO
CREATE TABLE [dbo].[Add_Update_Drive](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Academic_Year] [nvarchar](50) NULL,
	[Company_ID] [nvarchar](50) NULL,
	[Company_Name] [nvarchar](50) NULL,
	[Drive_Title] [nvarchar](50) NULL,
	[Post_Opened] [nvarchar](50) NULL,
	[Job_Type] [nvarchar](50) NULL,
	[Job_Profile] [nvarchar](50) NULL,
	[Salary] [nvarchar](50) NULL,
	[Vacancies] [nvarchar](50) NULL,
	[Bond] [nvarchar](50) NULL,
	[Bond_Duration] [nvarchar](50) NULL,
	[Bond_Amount] [nvarchar](50) NULL,
	[Bond_Terms] [nvarchar](50) NULL,
	[Security_Deposite] [nvarchar](50) NULL,
	[Joining_Date] [nvarchar](50) NULL,
	[Gender_Allowed] [nvarchar](50) NULL,
	[Recruitment_Method] [nvarchar](50) NULL,
	[Job_Location] [nvarchar](50) NULL,
	[Reg_From_Date] [nvarchar](50) NULL,
	[Reg_To_Date] [nvarchar](50) NULL,
	[Doc_Needed] [nvarchar](50) NULL,
	[Remark] [nvarchar](50) NULL,
	[Company_Coordinator] [nvarchar](50) NULL,
	[Company_Designation] [nvarchar](50) NULL,
	[Company_Contact] [nvarchar](50) NULL,
	[Institute_Coordinator] [nvarchar](50) NULL,
	[Institute_Designation] [nvarchar](50) NULL,
	[Institute_Contact] [nvarchar](50) NULL,
	[Courses] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NULL
	)

 
GO
CREATE TABLE [dbo].[Company_Registration](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Company_id] [nvarchar](10) NULL,
	[Company_name] [nvarchar](50) NULL,
	[Contact_person] [nvarchar](100) NULL,
	[Designation] [nvarchar](50) NULL,
	[Mobile_no] [varchar](50) NULL,
	[office_no] [varchar](50) NULL,
	[email_id] [varchar](50) NULL,
	[website] [nvarchar](50) NULL,
	[addressline] [nvarchar](max) NULL,
	[company_type] [nvarchar](max) NULL,
	[service_type] [nvarchar](max) NULL,
	[service_domain] [nvarchar](max) NULL,
	[Description] [nvarchar](50) NULL,
	[company_logo] [nvarchar](max) NULL,
	[Registration_date] [nvarchar](50) NULL
	)

GO
CREATE TABLE [dbo].[emp_regi](
	[emp_id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[fnm] [varchar](50) NULL,
	[mnm] [varchar](50) NULL,
	[lnm] [varchar](50) NULL,
	[id_proof] [nvarchar](50) NULL,
	[id_no] [varchar](18) NULL,
	[gender] [varchar](20) NULL,
	[dob] [nvarchar](50) NULL,
	[city] [varchar](50) NULL,
	[state] [varchar](50) NULL,
	[pin] [varchar](6) NULL,
	[address] [nvarchar](50) NULL,
	[contact] [varchar](18) NULL,
	[alt_contact_no] [varchar](18) NULL,
	[email] [varchar](100) NULL,
	[status] [nvarchar](10) NULL,
	[Department] [nvarchar](50) NULL,
	[Designation] [nvarchar](max) NULL,
	[Joining_Date] [nvarchar](50) NULL
	)

GO
CREATE TABLE [dbo].[Institute_registration](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Institute_name] [varchar](max) NULL,
	[contact_no] [varchar](50) NULL,
	[email_id] [varchar](50) NULL,
	[website] [varchar](50) NULL,
	[addressline1] [varchar](max) NULL,
	[addressline2] [varchar](max) NULL,
	[town] [varchar](50) NULL,
	[district] [varchar](50) NULL,
	[post_code] [varchar](50) NULL,
	[mail_Email_id] [varchar](max) NULL,
	[mail_password] [varchar](50) NULL,
	[smtp] [varchar](50) NULL,
	[port] [varchar](50) NULL,
	[link] [varchar](50) NULL,
	[smsid] [varchar](50) NULL,
	[smspass] [varchar](50) NULL
	)

GO
CREATE TABLE [dbo].[Placement_Login](
	[username] [nvarchar](max) NOT NULL,
	[login_password] [nvarchar](50) NULL,
	[login_role] [nvarchar](50) NULL,
	[status] [nvarchar](50) NULL
)

GO
CREATE TABLE [dbo].[Set_Drive_Criteria](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Academic_Year] [nvarchar](50) NULL,
	[Company_ID] [nvarchar](50) NULL,
	[Drive_Title] [nvarchar](50) NULL,
	[SSC_Percentage] [nvarchar](50) NULL,
	[Year1_Percentage] [nvarchar](50) NULL,
	[Year1_SGPA] [nvarchar](50) NULL,
	[SSC_Passed_Year] [nvarchar](50) NULL,
	[Year2_Percentage] [nvarchar](50) NULL,
	[Year2_SGPA] [nvarchar](50) NULL,
	[HSC_Percentage] [nvarchar](50) NULL,
	[Year3_Percentage] [nvarchar](50) NULL,
	[Year3_SGPA] [nvarchar](50) NULL,
	[HSC_Passed_Year] [nvarchar](50) NULL,
	[Year4_Percentage] [nvarchar](50) NULL,
	[Year4_SGPA] [nvarchar](50) NULL,
	[Diploma_Percentage] [nvarchar](50) NULL,
	[Year5_Percentage] [nvarchar](50) NULL,
	[Year5_SGPA] [nvarchar](50) NULL,
	[Diploma_Passed_Year] [nvarchar](50) NULL,
	[Sem1_Percentage] [nvarchar](50) NULL,
	[Sem1_SGPA] [nvarchar](50) NULL,
	[UG_Percentage] [nvarchar](50) NULL,
	[Sem2_Percentage] [nvarchar](50) NULL,
	[Sem2_SGPA] [nvarchar](50) NULL,
	[UG_Passed_Year] [nvarchar](50) NULL,
	[Sem3_Percentage] [nvarchar](50) NULL,
	[Sem3_SGPA] [nvarchar](50) NULL,
	[PG_Percentage] [nvarchar](50) NULL,
	[Sem4_Percentage] [nvarchar](50) NULL,
	[Sem4_SGPA] [nvarchar](50) NULL,
	[PG_Passed_Year] [nvarchar](50) NULL,
	[Sem5_Percentage] [nvarchar](50) NULL,
	[Sem5_SGPA] [nvarchar](50) NULL,
	[Gap_Year] [nvarchar](50) NULL,
	[Sem6_Percentage] [nvarchar](50) NULL,
	[Sem6_SGPA] [nvarchar](50) NULL,
	[Live_Backlogs] [nvarchar](50) NULL,
	[Sem7_Percentage] [nvarchar](50) NULL,
	[Sem7_SGPA] [nvarchar](50) NULL,
	[Dead_Backlogs] [nvarchar](50) NULL,
	[Sem8_Percentage] [nvarchar](50) NULL,
	[Sem8_SGPA] [nvarchar](50) NULL,
	[Experience] [nvarchar](50) NULL,
	[Entrance_Score] [nvarchar](50) NULL,
	[Aggregate] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL
	)

GO
CREATE TABLE [dbo].[Set_Drive_Schedule](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Academic_Year] [nvarchar](50) NULL,
	[Company_ID] [nvarchar](50) NULL,
	[Drive_Title] [nvarchar](50) NULL,
	[Round_Number] [nvarchar](50) NULL,
	[Round_Title] [nvarchar](50) NULL,
	[Round_Date] [nvarchar](50) NULL,
	[Round_Timing] [nvarchar](50) NULL,
	[Venue] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL
	)

GO
CREATE TABLE [dbo].[Stud_Project_Details](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Student_ID] [nvarchar](50) NULL,
	[Project_Type] [nvarchar](50) NULL,
	[Project_Title] [nvarchar](50) NULL,
	[Project_Domain] [nvarchar](50) NULL,
	[Project_Duration] [nvarchar](50) NULL,
	[Technologies] [nvarchar](50) NULL,
	[Team_Size] [nvarchar](50) NULL,
	[Guide_Name] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL
	)

GO
CREATE TABLE [dbo].[Student_Applied_Drive](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Student_ID] [int] NULL,
	[Company_ID] [nvarchar](50) NULL,
	[Company_Name] [nvarchar](50) NULL,
	[Drive_Title] [nvarchar](50) NULL,
	[Reg_From_Date] [nvarchar](50) NULL,
	[Reg_To_Date] [nvarchar](50) NULL,
	[AppliedDate] [nvarchar](50) NULL,
	[Round] [nvarchar](50) NULL
	)

GO
CREATE TABLE [dbo].[Student_Registration](
	[Student_ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Academic_Year] [nvarchar](50) NULL,
	[Course_Name] [nvarchar](50) NULL,
	[Aadhaar_No] [nvarchar](50) NULL,
	[University_Reg_No] [nvarchar](50) NULL,
	[Class_ID] [nvarchar](50) NULL,
	[Roll_No] [nvarchar](50) NULL,
	[Student_Name] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[Contact_No] [nvarchar](50) NULL,
	[alt_contact_no] [nvarchar](50) NULL,
	[Mother_Name] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[DOB] [nvarchar](50) NULL,
	[Blood_Group] [nvarchar](50) NULL,
	[Mother_Tongue] [nvarchar](50) NULL,
	[Languages] [nvarchar](50) NULL,
	[Admission_Date] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Nationality] [nvarchar](50) NULL,
	[Domicile] [nvarchar](50) NULL,
	[Religion] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[Caste] [nvarchar](50) NULL,
	[Hostelite] [nvarchar](50) NULL,
	[Handicap] [nvarchar](50) NULL,
	[Sport] [nvarchar](50) NULL,
	[Defence] [nvarchar](50) NULL,
	[PAN_No] [nvarchar](50) NULL,
	[Passport_No] [nvarchar](50) NULL,
	[Driving_License] [nvarchar](50) NULL,
	[F_Name] [nvarchar](50) NULL,
	[F_Contact] [nvarchar](50) NULL,
	[F_Email] [nvarchar](50) NULL,
	[F_Occupation] [nvarchar](50) NULL,
	[F_Organization] [nvarchar](50) NULL,
	[F_Designation] [nvarchar](50) NULL,
	[F_Address] [nvarchar](max) NULL,
	[F_Annual_Income] [nvarchar](50) NULL,
	[SSC_Board] [nvarchar](50) NULL,
	[SSC_Institute] [nvarchar](50) NULL,
	[SSC_Percentage] [nvarchar](50) NULL,
	[SSC_Passed_Year] [nvarchar](50) NULL,
	[SSC_Attempt] [nvarchar](50) NULL,
	[HSC_Board] [nvarchar](50) NULL,
	[HSC_Institute] [nvarchar](50) NULL,
	[HSC_Percentage] [nvarchar](50) NULL,
	[HSC_Passed_Year] [nvarchar](50) NULL,
	[HSC_Attempt] [nvarchar](50) NULL,
	[Diploma_Board] [nvarchar](50) NULL,
	[Diploma_Institute] [nvarchar](50) NULL,
	[Diploma_Percentage] [nvarchar](50) NULL,
	[Diploma_Passed_Year] [nvarchar](50) NULL,
	[Diploma_Attempt] [nvarchar](50) NULL,
	[UG_Board] [nvarchar](50) NULL,
	[UG_Institute] [nvarchar](50) NULL,
	[UG_Percentage] [nvarchar](50) NULL,
	[UG_Passed_Year] [nvarchar](50) NULL,
	[UG_Attempt] [nvarchar](50) NULL,
	[PG_Board] [nvarchar](50) NULL,
	[PG_Institute] [nvarchar](50) NULL,
	[PG_Percentage] [nvarchar](50) NULL,
	[PG_Passed_Year] [nvarchar](50) NULL,
	[PG_Attempt] [nvarchar](50) NULL,
	[Sem1_Obtained_Marks] [nvarchar](50) NULL,
	[Sem1_Total_Marks] [nvarchar](50) NULL,
	[Sem1_Percentage] [nvarchar](50) NULL,
	[Sem1_SGPA] [nvarchar](50) NULL,
	[Sem1_BackLog] [nvarchar](50) NULL,
	[Sem2_Obtained_Marks] [nvarchar](50) NULL,
	[Sem2_Total_Marks] [nvarchar](50) NULL,
	[Sem2_Percentage] [nvarchar](50) NULL,
	[Sem2_SGPA] [nvarchar](50) NULL,
	[Sem2_BackLog] [nvarchar](50) NULL,
	[Sem3_Obtained_Marks] [nvarchar](50) NULL,
	[Sem3_Total_Marks] [nvarchar](50) NULL,
	[Sem3_Percentage] [nvarchar](50) NULL,
	[Sem3_SGPA] [nvarchar](50) NULL,
	[Sem3_BackLog] [nvarchar](50) NULL,
	[Sem4_Obtained_Marks] [nvarchar](50) NULL,
	[Sem4_Total_Marks] [nvarchar](50) NULL,
	[Sem4_Percentage] [nvarchar](50) NULL,
	[Sem4_SGPA] [nvarchar](50) NULL,
	[Sem4_BackLog] [nvarchar](50) NULL,
	[Sem5_Obtained_Marks] [nvarchar](50) NULL,
	[Sem5_Total_Marks] [nvarchar](50) NULL,
	[Sem5_Percentage] [nvarchar](50) NULL,
	[Sem5_SGPA] [nvarchar](50) NULL,
	[Sem5_BackLog] [nvarchar](50) NULL,
	[Sem6_Obtained_Marks] [nvarchar](50) NULL,
	[Sem6_Total_Marks] [nvarchar](50) NULL,
	[Sem6_Percentage] [nvarchar](50) NULL,
	[Sem6_SGPA] [nvarchar](50) NULL,
	[Sem6_BackLog] [nvarchar](50) NULL,
	[Sem7_Obtained_Marks] [nvarchar](50) NULL,
	[Sem7_Total_Marks] [nvarchar](50) NULL,
	[Sem7_Percentage] [nvarchar](50) NULL,
	[Sem7_SGPA] [nvarchar](50) NULL,
	[Sem7_BackLog] [nvarchar](50) NULL,
	[Sem8_Obtained_Marks] [nvarchar](50) NULL,
	[Sem8_Total_Marks] [nvarchar](50) NULL,
	[Sem8_Percentage] [nvarchar](50) NULL,
	[Sem8_SGPA] [nvarchar](50) NULL,
	[Sem8_BackLog] [nvarchar](50) NULL,
	[Year1_Obtained_Marks] [nvarchar](50) NULL,
	[Year1_Total_Marks] [nvarchar](50) NULL,
	[Year1_Percentage] [nvarchar](50) NULL,
	[Year1_SGPA] [nvarchar](50) NULL,
	[Year1_BackLog] [nvarchar](50) NULL,
	[Year2_Obtained_Marks] [nvarchar](50) NULL,
	[Year2_Total_Marks] [nvarchar](50) NULL,
	[Year2_Percentage] [nvarchar](50) NULL,
	[Year2_SGPA] [nvarchar](50) NULL,
	[Year2_BackLog] [nvarchar](50) NULL,
	[Year3_Obtained_Marks] [nvarchar](50) NULL,
	[Year3_Total_Marks] [nvarchar](50) NULL,
	[Year3_Percentage] [nvarchar](50) NULL,
	[Year3_SGPA] [nvarchar](50) NULL,
	[Year3_BackLog] [nvarchar](50) NULL,
	[Year4_Obtained_Marks] [nvarchar](50) NULL,
	[Year4_Total_Marks] [nvarchar](50) NULL,
	[Year4_Percentage] [nvarchar](50) NULL,
	[Year4_SGPA] [nvarchar](50) NULL,
	[Year4_BackLog] [nvarchar](50) NULL,
	[Year5_Obtained_Marks] [nvarchar](50) NULL,
	[Year5_Total_Marks] [nvarchar](50) NULL,
	[Year5_Percentage] [nvarchar](50) NULL,
	[Year5_SGPA] [nvarchar](50) NULL,
	[Year5_BackLog] [nvarchar](50) NULL,
	[Gap_Year] [nvarchar](50) NULL,
	[Live_Backlogs] [nvarchar](50) NULL,
	[Dead_Backlogs] [nvarchar](50) NULL,
	[Experience] [nvarchar](50) NULL,
	[Entrance_Score] [nvarchar](50) NULL,
	[Aggregate] [nvarchar](50) NULL,
	[status] [nvarchar](50) NULL,
	[Approuvel] [nvarchar](50) NULL,
	[Photo] [image] NULL
	)

GO
Create procedure [dbo].[add_student_extraActivity]
(
 @flag int,
 @Student_ID int= null,
 @Activity_Tital nvarchar(100)=null,
 @Activity_Details nvarchar(MAX)=null,
 @Description nvarchar(MAX)=null
)
as
begin
	begin				/****** Member All Detail View ******/
		if(@flag=1)
			insert into Add_Student_Activity (Student_id,Activity_Title,Activity_Details,Description) values(@Student_ID,@Activity_Tital,@Activity_Details,@Description)   
    end
	begin				/****** Member All Detail View ******/
		if(@flag=2)
		select * from Add_Student_Activity;
	end

END

GO
CREATE PROCEDURE [dbo].[Auto_Company_id]	 
	AS
BEGIN
   Declare @maxno int , @no varchar(40)
   select @maxno = ISNULL(MAX(CAST(Right(Company_id,5)as nvarchar)),0)+1 from Company_Registration
   select 'COM'+ RIGHT('00000'+CAST (@maxno as nvarchar),5)
   

    END
GO
CREATE PROCEDURE [dbo].[Auto_Staff_id]	 
	AS
BEGIN
   Declare @maxno int , @no varchar(40)
   select @maxno = ISNULL(MAX(CAST(Right(emp_id,5)as nvarchar)),0)+1 from emp_regi
   select 'EMP'+ RIGHT('00000'+CAST (@maxno as nvarchar),5)
   

    END
GO
CREATE PROCEDURE [dbo].[Auto_Student_id]	 
	AS
BEGIN
   Declare @maxno int , @no varchar(40)
   select @maxno = ISNULL(MAX(CAST(Right(Student_ID,5)as nvarchar)),0)+1 from Student_Registration
   select 'STU'+ RIGHT('00000'+CAST (@maxno as nvarchar),5)
   

    END

GO

CREATE PROCEDURE [dbo].[Company_Details]	 
(
	@flag int,
	@Company_id	nvarchar(MAX) =Null,	
	@Company_name	varchar(MAX)=Null,
	@Contact_person	nvarchar(MAX)=Null,
	@Designation	nvarchar(MAX)=Null,	
	@Mobile_no	varchar(13)=Null,
	@office_no   varchar(50)=Null,	
	@email_id	varchar(50)=Null,	
	@website	nvarchar(50)=Null,
	@addressline	nvarchar(MAX)=Null,	
	@company_type	nvarchar(MAX)=Null,
	@service_type	nvarchar(MAX)=Null,	
	@service_domain	nvarchar(MAX)=Null,	
	@Description	nvarchar(MAX)=Null,	
	@Username	nvarchar(MAX)=Null,	
	@Password	nvarchar(MAX)=Null,
	@Registration_date nvarchar(Max)=Null,
	@start_date nvarchar(50)=Null,
	@end_date nvarchar(50)=Null
	)
	
	
		 as
		 begin
			 begin
			 
					 if(@flag=1)
             
		      insert into Company_Registration(Company_id,Company_name,Contact_person,Designation,Mobile_no,office_no,email_id,website,addressline,company_type,service_type,service_domain,Description,Registration_date)
              values(@Company_id,@Company_name,@Contact_person,@Designation,@Mobile_no,@office_no,@email_id,@website,@addressline,@company_type,@service_type,@service_domain,@Description,@Registration_date)
            end
            
            begin
                   if(@flag=2)
                   
                   update Company_Registration set Company_name=Company_name,Contact_person=@Contact_person,Designation=@Designation,Mobile_no=@Mobile_no,office_no=@office_no,email_id=@email_id,addressline=@addressline,company_type=@company_type,service_domain=@service_domain,Description=@Description where Company_id=@Company_id
                   end
			begin
			     
			     if(@flag=3)         
			     
			      select* from  Company_Registration 
			      end
			      
			 begin
			 if(@flag=4) 
			 
			 select* from  Company_Registration where Company_id=@Company_id
			 end
			 begin
			 if(@flag=5) 
			 
			 select* from  Company_Registration where Company_name=@Company_name
			 end
			 begin
			 if(@flag=6) 
			 
			Select * from Company_Registration where CONVERT(date,Registration_date,103) BETWEEN CONVERT(date,@start_date,103) AND CONVERT(date,@end_date,103)
			 end
  End

GO
CREATE procedure [dbo].[Institute_Details]
(
           @flag int,  
           @Institute_name nvarchar(50) =null,
           @contact_no  nvarchar(50) =null,
           @email_id  nvarchar(50) =null,
           @website  nvarchar(50) =null,
           @addressline1  nvarchar(50) =null,
           @addressline2  nvarchar(50) =null,
           @town  nvarchar(50) =null,
           @district  nvarchar(50) =null,
           @post_code  nvarchar(50) =null,
           @mail_Email_id  nvarchar(50) =null,
           @mail_password  nvarchar(50) =null,
           @smtp  nvarchar(50) =null,
           @port  nvarchar(50) =null,
           @link  nvarchar(50) =null,
           @smsid  nvarchar(50) =null,
           @smspass  nvarchar(50) =null 

)
as
begin
  begin				/****** Insert Institute Detail ******/
	if(@flag=1)
		insert into Institute_registration(Institute_name,contact_no,
  email_id,website,addressline1,addressline2,town,district,post_code,
  mail_Email_id,mail_password,smtp,port,link,smsid,smspass)
  values (@Institute_name,@contact_no,@email_id,@website,
  @addressline1,@addressline2,@town,@district,@post_code,@mail_Email_id,
  @mail_password,@smtp,@port,@link,@smsid,@smspass)  
  end
  
  begin				/****** Update Institute Details ******/
	if(@flag=2)
		update TOP (1) Institute_registration set Institute_name=@Institute_name,contact_no=@contact_no,
email_id=@email_id,website=@website,addressline1=@addressline1,addressline2=@addressline2,
town=@town,district=@district,post_code=@post_code,mail_Email_id=@mail_Email_id,
mail_password=@mail_password,smtp=@smtp,port=@port,link=@link,smsid=@smsid,
smspass=@smspass  
  end
 
  begin				/****** Select Institute Detail View ******/
	 if(@flag=3)
		Select * from Institute_registration
  end
  begin				/****** Cont Institute List ******/
	 if(@flag=4)
		SELECT count(*) from Institute_registration
  end
END

GO
CREATE PROCEDURE [dbo].[Login_Details]

@flag int,
@username nvarchar(Max) = null,
 @password nvarchar(50) = null,
 @role nvarchar(50) = null,
 @status nvarchar(10) = null,
 @old_pswd nvarchar(50) = null
AS
BEGIN


  begin				/****** Insert Login Detail ******/
	if(@flag=1)
		insert into Placement_Login (username,login_password,login_role,status) values(@username,@password,@role,@status) 
  end
  
  begin				/****** Update Login Details ******/
	if(@flag=2)
		update Placement_Login set username=@username,login_password=@password where username=@username AND login_password=@old_pswd
  end
 
  begin				/****** Employee Login Status Update ******/
	 if(@flag=3)
		update Placement_Login set status=@status where username=@username 
		update emp_regi set status=@status where email=@username
  end
  begin				/****** Student Login Status Update ******/
	 if(@flag=4)
		update Placement_Login set status=@status where username=@username
		update Student_Registration set status=@status where Email=@username
  end
  begin				/****** Student Login Status Update ******/
	 if(@flag=5)
		select S.Student_Name,S.Contact_No,S.Email,L.username,L.login_password,L.login_role,L.status from Student_Registration S Inner Join Placement_Login L on (S.Email=L.username) 
  end
    begin				/****** Student Login Status Update ******/
	 if(@flag=6)
		select S.Student_Name,S.Contact_No,S.Email,L.username,L.login_password,L.login_role,L.status from Student_Registration S Inner Join Placement_Login L on (S.Email=L.username) where L.username=@username
  end
END

GO
CREATE PROCEDURE [dbo].[message_details]

 @flag int,
 @id int=null,
 @subject varchar(max)=null,
 @body varchar(max)=null
AS
BEGIN


  begin				/****** Add Event Details ******/
	if(@flag=1)
		insert into add_event (subject,body) values(@subject,@body)
  end
  
  begin				/****** binding ddl event ******/
	 if(@flag=2)
		select subject,event_id from add_event order by subject asc
  end

  begin				/****** Member Package Wise Detail View ******/
	if(@flag=3)
		select subject,body from add_event where event_id = @id
  end
 end

GO
CREATE PROCEDURE [dbo].[Search_Student_details]

@flag int,
@lname varchar(50)=null,
@id nvarchar(50)=null,
@package_name varchar (50)=null,
@Class nvarchar(50)=null,
@division nvarchar(50)=null,
@House_Colour nvarchar(50)=null
AS
BEGIN


  begin				/****** Member All Detail View ******/
	if(@flag=1)
		Select * from Student_Registration
  end
  
  begin				/****** Member Id Wise Detail View where status='Active' ******/
	if(@flag=2)
		Select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id)  where m.Student_id=@id and status='Active'
		/****** Select * from Student_Registration where Student_id=@id and status='Active' ******/
  end
 
  begin				/****** Member Last Name Wise Detail View ******/
	 if(@flag=3)
		select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id) where m.lnm like @lname + '%' OR @lname = ''  and status='Active'
  end

  begin				/****** Member Package Wise Detail View ******/
	if(@flag=4)
		Select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) where r.package=@package_name  and status='Active'
  end

  begin				/****** Member Id Wise Detail View ******/
	if(@flag=5)
		Select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id)  where m.Student_id=@id  and status='Active'
  end
   begin				/****** Member All Detail View  where status='Active' ******/
	if(@flag=6)
		Select * from Student_Registration  where status='Active'
  end
  begin				/****** Member All Detail View  where status='Active' ******/
	if(@flag=7)
		Select * from Student_Registration  where Student_id=@id and status='Active'
  end
  begin				/****** Member Last Name Wise Detail View ******/
	 if(@flag=8)
		select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id) where m.lnm like @lname + '%' OR @lname = '' and status='Active'
  end
  begin				/****** Member Class Wise Detail View where status='Active' ******/
	if(@flag=10)
		Select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id)  where r.Class=@Class and m.status='Active'
		/****** Select * from Student_Registration where Student_id=@id and status='Active' ******/
  end
  begin				/****** Member House_Colour Wise Detail View where status='Active' ******/
	if(@flag=11)
		Select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id)  where r.House_Colour=@House_Colour and m.status='Active'
		/****** Select * from Student_Registration where Student_id=@id and status='Active' ******/
  end
  begin				/****** Member  registration and renewal Detail View where status='Active' ******/
	if(@flag=12)
		Select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id) where m.status='Active'
  end
  begin				/****** Member Class Wise Detail View where status='Active' ******/
	if(@flag=13)
		Select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id)  where r.Class=@Class and r.House_Colour=@House_Colour and m.status='Active'
		/****** Select * from Student_Registration where Student_id=@id and status='Active' ******/
  end
  begin				/****** Member Class Wise Detail View where status='Active' ******/
	if(@flag=14)
		Select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id)  where r.Division=@division and m.status='Active'
		/****** Select * from Student_Registration where Student_id=@id and status='Active' ******/
  end
  begin				/****** Member Class Wise Detail View where status='Active' ******/
	if(@flag=15)
		Select * from Student_Registration m Inner Join member_renewal r on (m.package_id=r.package_id) and (m.Student_id=r.Student_id)  where r.Class=@Class and r.Division=@division and m.status='Active'
		/****** Select * from Student_Registration where Student_id=@id and status='Active' ******/
  end
END
 
GO


CREATE procedure[dbo].[Sp_Add_Achievement_Details]
(		
		@flag int,
		@studentID nvarchar(50)=Null,	
		@Achievement_Title	nvarchar(Max)=Null,		
		@Achievement_Details nvarchar(Max)=Null,		
		@Description nvarchar(Max)=Null	
		
)
as
begin 
 begin
     if(@flag=1)
       insert into Add_Achievement(studentID,Achievement_Title,Achievement_Details,Description)
       values(@studentID,@Achievement_Title,@Achievement_Details,@Description)
       
       end
       begin
     if(@flag=2)
        
        select* from Add_Achievement where studentID=@studentID 
      
       end
      End

GO

CREATE procedure[dbo].[Sp_Add_Technical_Details]
(
	@flag int,
	@stuID	nvarchar (10)= Null,
	@Course_Title	nvarchar(50)=Null,	
	@Technical_Details	nvarchar(Max)=Null,	
	@Description	nvarchar(Max)=Null	
)
as
begin
  begin
    if(@flag=1)
    
    insert into Add_Technical_Deatils(stuID,Course_Title,Technical_Details,Description)
    values(@stuID,@Course_Title,@Technical_Details,@Description)
     end
     
     begin
    if(@flag=2)
         select* from Add_Technical_Deatils where stuID=@stuID
  
     end
 
   End

GO


CREATE procedure[dbo].[Sp_Add_Total_Marks]
(       @flag int,
		@Academic_Year	nvarchar(50)=Null,	
		@First_Year_Marks	nvarchar(50)=Null,	
		@Second_Year_Marks	nvarchar(50)=Null,	
		@Third_Year_Marks	nvarchar(50)=Null,	
		@Fourth_Year_Marks	nvarchar(50)=Null,	
		@Fifth_Year_Marks	nvarchar(50)=Null,	
		@Sem_1_Marks	nvarchar(50)=Null,	
		@Sem_2_Marks	nvarchar(50)=Null,	
		@Sem_3_Marks	nvarchar(50)=Null,	
		@Sem_4_Marks	nvarchar(50)=Null,	
		@Sem_5_Marks	nvarchar(50)=Null,	
		@Sem_6_Marks	nvarchar(50)=Null,	
		@Sem_7_Marks	nvarchar(50)=Null,	
		@Sem_8_Marks	nvarchar(50)=Null,	
		@Sem_9_Marks	nvarchar(50)=Null,	
		@Sem_10_Marks	nvarchar(50)=Null
		
	)
	
	as
	begin
	  begin 
	  if(@flag=1)
	  insert into Add_Total_Marks(Academic_Year,First_Year_Marks,Second_Year_Marks,Third_Year_Marks,Fourth_Year_Marks,Fifth_Year_Marks	,
				  Sem_1_Marks,Sem_2_Marks,Sem_3_Marks,Sem_4_Marks,Sem_5_Marks,Sem_6_Marks,Sem_7_Marks,Sem_8_Marks,Sem_9_Marks,Sem_10_Marks )	
				  
	  values(@Academic_Year,@First_Year_Marks,@Second_Year_Marks,@Third_Year_Marks,@Fourth_Year_Marks,@Fifth_Year_Marks,@Sem_1_Marks,@Sem_2_Marks,@Sem_3_Marks,
	  		 @Sem_4_Marks,@Sem_5_Marks,@Sem_6_Marks,@Sem_7_Marks,@Sem_8_Marks,@Sem_9_Marks,@Sem_10_Marks )	
	  		 end
	 End

GO
  
  
    
CREATE PROCEDURE [dbo].[SP_Add_Update_Drive]              
(            
 @flag int,            
 @Academic_Year nvarchar(MAX) =Null,            
 @Company_ID nvarchar(MAX)=Null,             
 @Company_name nvarchar(MAX)=Null,            
 @Drive_Title nvarchar(MAX)=Null,            
 @Post_Opened nvarchar(MAX)=Null,             
 @Job_Type nvarchar(MAX)=Null,            
 @Job_Profile varchar(MAX)=Null,             
 @Salary nvarchar(MAX)=Null,             
 @Vacancies nvarchar(MAX)=Null,            
 @Bond nvarchar(MAX)=Null,             
 @Bond_Duration nvarchar(MAX)=Null,             
 @Bond_Amount nvarchar(MAX)=Null,            
 @Bond_Terms nvarchar(MAX)=Null,             
 @Security_Deposite nvarchar(MAX)=Null,             
 @Joining_Date nvarchar(MAX)=Null,             
 @Gender_Allowed nvarchar(MAX)=Null,             
 @Recruitment_Method nvarchar(MAX)=Null,            
 @Job_Location nvarchar(MAX)=Null,            
 @Reg_From_Date nvarchar(MAX)=Null,            
 @Reg_To_Date nvarchar(MAX)=Null,            
 @Doc_Needed nvarchar(MAX)=Null,            
 @Remark nvarchar(MAX)=Null,            
 @Company_Coordinator nvarchar(MAX)=Null,            
 @Company_Designation nvarchar(MAX)=Null,            
 @Company_Contact nvarchar(MAX)=Null,             
 @Institute_Coordinator nvarchar(MAX)=Null,            
 @Institute_Designation nvarchar(MAX)=Null,            
 @Institute_Contact nvarchar(MAX)=Null,            
 @Courses nvarchar(MAX)=Null,
 @Status nvarchar(MAX)=Null            
           
)            
            
 as            
  begin            
    begin            
                
      if(@flag=1)            
                         
        insert into Add_Update_Drive(Academic_Year,Company_ID,Company_name,Drive_Title,        
        Post_Opened,Job_Type,Job_Profile,Salary,Vacancies,Bond,Bond_Duration,Bond_Amount,        
        Bond_Terms,Security_Deposite,Joining_Date,Gender_Allowed,Recruitment_Method,        
        Job_Location,Reg_From_Date,Reg_To_Date,Doc_Needed,Remark,Company_Coordinator,        
        Institute_Designation,Institute_Contact,Courses,Status        
        )values(@Academic_Year,@Company_ID,@Company_name,@Drive_Title,        
        @Post_Opened,@Job_Type,@Job_Profile,@Salary,@Vacancies,@Bond,@Bond_Duration,        
        @Bond_Amount,@Bond_Terms,@Security_Deposite,@Joining_Date,@Gender_Allowed,        
        @Recruitment_Method,@Job_Location,@Reg_From_Date,@Reg_To_Date,@Doc_Needed,        
        @Remark,@Company_Coordinator,@Institute_Designation,@Institute_Contact,@Courses,        
        @Status)            
            end            
                        
            begin            
                   if(@flag=2)            
                               
                   update Update_Drive set Academic_Year=@Academic_Year,Company_ID=@Company_ID,Company_name=@Company_name,Post_Opened=@Post_Opened,Job_Type=@Job_Type,Job_Profile=@Job_Profile,Salary=@Salary,Vacancies=@Vacancies,        
                   Bond=@Bond,Bond_Duration=@Bond_Duration,Bond_Amount=@Bond_Amount,Bond_Terms=@Bond_Terms,        
                   Security_Deposite=@Security_Deposite,Joining_Date=@Joining_Date,Gender_Allowed=@Gender_Allowed,        
                   Recruitment_Method=@Recruitment_Method,Job_Location=@Job_Location,        
                   Reg_From_Date=@Reg_From_Date,Reg_To_Date=@Reg_To_Date,Doc_Needed=@Doc_Needed,        
                   Remark=@Remark,Company_Coordinator=@Company_Coordinator,Institute_Designation=@Institute_Designation,        
                   Institute_Contact=@Institute_Contact,Courses=@Courses,Status=@Status        
                    where Drive_Title=@Drive_Title            
                   end            
   begin            
                    
        if(@flag=3)                     
                    
         select* from  Add_Update_Drive             
         end            
                     
    begin           
    if(@flag=4)             
                
    select* from  Add_Update_Drive where Drive_Title=@Drive_Title         
    end        
  
     begin            
    if(@flag=5)             
                
    select* from  Add_Update_Drive where Company_ID=@Company_ID and Academic_Year=@Academic_Year         
    end   
      
      begin            
    if(@flag=5)             
                
    select* from  Add_Update_Drive where Company_ID=@Company_ID and Academic_Year=@Academic_Year         
    end            
       
     begin  
     if(@flag=6)  
     update Add_Update_Drive set Status=@Status where Company_ID=@Company_ID and Academic_Year=@Academic_Year  and Drive_Title=@Drive_Title   
      end     
      begin  
     if(@flag=7)  
     select [Company_ID],[Company_Name],[Drive_Title],[Reg_From_Date],[Reg_To_Date] from [Add_Update_Drive] order by [id] desc
      end           
  End  

GO
  
Create PROCEDURE [dbo].[SP_Project_Details_Stud]            
(          
@flag int,          
@id	int,	
@Stud_id	nvarchar(MAX) =Null,          	
@Project_Type	nvarchar(MAX) =Null,          
@Project_Title	nvarchar(MAX) =Null,          	
@Project_Domain	nvarchar(MAX) =Null,          	
@Project_Duration	nvarchar(MAX) =Null,          	
@Technologies	nvarchar(MAX) =Null,          	
@Team_Size	nvarchar(MAX) =Null,          	
@Guide_Name	nvarchar(MAX) =Null,          	
@Description	nvarchar(MAX) =Null 
)         
 as          
  begin          
    begin    
      if(@flag=1)     
       
       insert into Stud_Project_Details(Project_Type,Project_Title,Project_Domain,
       Project_Duration,Technologies,Team_Size,Guide_Name,Description)
       values(@Project_Type,@Project_Title,@Project_Domain,@Project_Duration,
       @Technologies,@Team_Size,@Guide_Name,@Description)          
    
     end  
                 
   begin          
      if(@flag=2) 
       
        update Stud_Project_Details set Project_Type=@Project_Type,Project_Title=@Project_Title,
         Project_Domain=@Project_Domain,Project_Duration=@Project_Duration,Technologies=@Technologies,
        Team_Size=@Team_Size,Guide_Name=@Guide_Name,Description=@Description where Student_ID=@Stud_id
   
    end          
  begin          
      if(@flag=3)                   
                  
         select* from  Stud_Project_Details           
         end          
                   
    begin          
    if(@flag=4)           
              
    select* from  Stud_Project_Details where Student_ID=@Stud_id       
    end      
      
     begin          
    if(@flag=5)           
              
    select* from  Stud_Project_Details 
    end          
              
  End 

GO

CREATE procedure[dbo].[Sp_Set_Drive_Criteria]  
(  
           @flag int,  
           @Academic_Year nvarchar(50)=Null,    
           @Company_ID   nvarchar(50)=Null,
           @Drive_Title   nvarchar(50)=Null,
           @SSC_Percentage   nvarchar(50)=Null,
           @Year1_Percentage   nvarchar(50)=Null,
           @Year1_SGPA   nvarchar(50)=Null,
           @SSC_Passed_Year   nvarchar(50)=Null,
           @Year2_Percentage   nvarchar(50)=Null,
           @Year2_SGPA   nvarchar(50)=Null,
           @HSC_Percentage   nvarchar(50)=Null,
           @Year3_Percentage   nvarchar(50)=Null,
           @Year3_SGPA   nvarchar(50)=Null,
           @HSC_Passed_Year   nvarchar(50)=Null,
           @Year4_Percentage   nvarchar(50)=Null,
           @Year4_SGPA   nvarchar(50)=Null,
           @Diploma_Percentage   nvarchar(50)=Null,
           @Year5_Percentage   nvarchar(50)=Null,
           @Year5_SGPA   nvarchar(50)=Null,
           @Diploma_Passed_Year   nvarchar(50)=Null,
           @Sem1_Percentage   nvarchar(50)=Null,
           @Sem1_SGPA   nvarchar(50)=Null,
           @UG_Percentage   nvarchar(50)=Null,
           @Sem2_Percentage   nvarchar(50)=Null,
           @Sem2_SGPA   nvarchar(50)=Null,
           @UG_Passed_Year   nvarchar(50)=Null,
           @Sem3_Percentage   nvarchar(50)=Null,
           @Sem3_SGPA   nvarchar(50)=Null,
           @PG_Percentage   nvarchar(50)=Null,
           @Sem4_Percentage   nvarchar(50)=Null,
           @Sem4_SGPA   nvarchar(50)=Null,
           @PG_Passed_Year   nvarchar(50)=Null,
           @Sem5_Percentage   nvarchar(50)=Null,
           @Sem5_SGPA   nvarchar(50)=Null,
           @Gap_Year   nvarchar(50)=Null,
           @Sem6_Percentage   nvarchar(50)=Null,
           @Sem6_SGPA   nvarchar(50)=Null,
           @Live_Backlogs   nvarchar(50)=Null,
           @Sem7_Percentage   nvarchar(50)=Null,
           @Sem7_SGPA   nvarchar(50)=Null,
           @Dead_Backlogs   nvarchar(50)=Null,
           @Sem8_Percentage   nvarchar(50)=Null,
           @Sem8_SGPA   nvarchar(50)=Null,
           @Experience   nvarchar(50)=Null,
           @Entrance_Score   nvarchar(50)=Null,
           @Aggregate   nvarchar(50)=Null
  )  
    
  as  
  begin   
    begin  
       if(@flag=1)  
         
       insert into Set_Drive_Criteria(Academic_Year,Company_ID,Drive_Title,SSC_Percentage,Year1_Percentage,
                 Year1_SGPA,SSC_Passed_Year,Year2_Percentage,Year2_SGPA,
                 HSC_Percentage,Year3_Percentage,Year3_SGPA,HSC_Passed_Year,
				 Year4_Percentage,Year4_SGPA,Diploma_Percentage,Year5_Percentage,
				 Year5_SGPA,Diploma_Passed_Year,Sem1_Percentage,Sem1_SGPA,
			     UG_Percentage,Sem2_Percentage,Sem2_SGPA,UG_Passed_Year,
	   			 Sem3_Percentage,Sem3_SGPA,PG_Percentage,Sem4_Percentage,Sem4_SGPA,
				 PG_Passed_Year,Sem5_Percentage,Sem5_SGPA,Gap_Year,Sem6_Percentage,
				 Sem6_SGPA,Live_Backlogs,Sem7_Percentage,Sem7_SGPA,Dead_Backlogs,
				 Sem8_Percentage,Sem8_SGPA,Experience,Entrance_Score,Aggregate) 
            
	Values(@Academic_Year,@Company_ID,@Drive_Title,@SSC_Percentage,@Year1_Percentage,
			    @Year1_SGPA,@SSC_Passed_Year,@Year2_Percentage,@Year2_SGPA,
			    @HSC_Percentage,@Year3_Percentage,@Year3_SGPA,@HSC_Passed_Year,
			    @Year4_Percentage,@Year4_SGPA,@Diploma_Percentage,@Year5_Percentage,
				@Year5_SGPA,@Diploma_Passed_Year,@Sem1_Percentage,@Sem1_SGPA,
				@UG_Percentage,@Sem2_Percentage,@Sem2_SGPA,@UG_Passed_Year,
				@Sem3_Percentage,@Sem3_SGPA,@PG_Percentage,@Sem4_Percentage,@Sem4_SGPA,
				@PG_Passed_Year,@Sem5_Percentage,@Sem5_SGPA,@Gap_Year,@Sem6_Percentage,
				@Sem6_SGPA,@Live_Backlogs,@Sem7_Percentage,@Sem7_SGPA,@Dead_Backlogs,
				@Sem8_Percentage,@Sem8_SGPA,@Experience,@Entrance_Score,@Aggregate) 
    end  
   begin  
        if(@flag=2)  
          
   update Set_Drive_Criteria set  Academic_Year=@Academic_Year,Company_ID=@Company_ID,Drive_Title=@Drive_Title,SSC_Percentage=@SSC_Percentage,
				Year1_Percentage=@Year1_Percentage,Year1_SGPA=@Year1_SGPA,SSC_Passed_Year=@SSC_Passed_Year,
				Year2_Percentage=@Year2_Percentage,Year2_SGPA=@Year2_SGPA,HSC_Percentage=@HSC_Percentage,
				Year3_Percentage=@Year3_Percentage,Year3_SGPA=@Year3_SGPA,HSC_Passed_Year=@HSC_Passed_Year,
				Year4_Percentage=@Year4_Percentage,Year4_SGPA=@Year4_SGPA,Diploma_Percentage=@Diploma_Percentage,
				Year5_Percentage=@Year5_Percentage,Year5_SGPA=@Year5_SGPA,Diploma_Passed_Year=@Diploma_Passed_Year,
				Sem1_Percentage=@Sem1_Percentage,Sem1_SGPA=@Sem1_SGPA,UG_Percentage=@UG_Percentage,Sem2_Percentage=@Sem2_Percentage,
				Sem2_SGPA=@Sem2_SGPA,UG_Passed_Year=@UG_Passed_Year,Sem3_Percentage=@Sem3_Percentage,Sem3_SGPA=@Sem3_SGPA,
				PG_Percentage=@PG_Percentage,Sem4_Percentage=@Sem4_Percentage,Sem4_SGPA=@Sem4_SGPA,PG_Passed_Year=@PG_Passed_Year,
				Sem5_Percentage=@Sem5_Percentage,Sem5_SGPA=@Sem5_SGPA,Gap_Year=@Gap_Year,Sem6_Percentage=@Sem6_Percentage,
				Sem6_SGPA=@Sem6_SGPA,Live_Backlogs=@Live_Backlogs,Sem7_Percentage=@Sem7_Percentage,Sem7_SGPA=@Sem7_SGPA,
				Dead_Backlogs=@Dead_Backlogs,Sem8_Percentage=@Sem8_Percentage,Sem8_SGPA=@Sem8_SGPA,
				Experience=@Experience,Entrance_Score=@Entrance_Score,Aggregate=@Aggregate where Academic_Year=@Academic_Year 
				and Company_ID=@Company_ID and Drive_Title=@Drive_Title
                                                                   
   end  
         
       begin  
     if(@flag=3)  
          
        select* from Set_Drive_Criteria   
        
       end        
   begin  
     if(@flag=4)  
          
        select* from Set_Drive_Criteria where Academic_Year=@Academic_Year and Company_ID=@Company_ID and Drive_Title=@Drive_Title   
        
       end  
End  

GO
CREATE procedure[dbo].[Sp_Set_Drive_Schedule]
(		
		@flag int,
		@Academic_Year nvarchar(MAX) =Null,        
		@Company_ID nvarchar(MAX)=Null,          
		@Drive_Title nvarchar(MAX)=Null,		    
		@Round_Number nvarchar (Max)=null,	
		@Round_Title	nvarchar (Max)=null,
		@Round_Date	nvarchar (Max)=null,
		@Round_Timing	nvarchar(Max)=null,
		@Venue	nvarchar (Max)=null,
		@Description	nvarchar (Max)=null
)
as
begin
begin
	if(@flag=1)
			insert into Set_Drive_Schedule(Academic_Year,Company_ID,Drive_Title,Round_Number,Round_Title,Round_Date,Round_Timing,Venue,Description)
			 values(@Academic_Year,@Company_ID,@Drive_Title,@Round_Number,@Round_Title,@Round_Date,@Round_Timing,@Venue,@Description)

			 
			end
			begin
			 if(@flag=2)         
				 update Set_Drive_Schedule set Academic_Year=@Academic_Year,Company_ID=@Company_ID,Drive_Title=@Drive_Title,Round_Number=@Round_Number,Round_Title=@Round_Title,Round_Date=@Round_Date,Round_Timing=@Round_Timing,Venue=@Venue,Description=@Description
				 where  Academic_Year=@Academic_Year and Company_ID=@Company_ID and Drive_Title=@Drive_Title and Round_Number=@Round_Number
			 end  
			begin
			 if(@flag=3)         
				 select * from  Set_Drive_Schedule where Academic_Year=@Academic_Year and Company_ID=@Company_ID and Drive_Title=@Drive_Title 
			 end  
			
		begin
			 if(@flag=5)         
				  select Round_Number=@Round_Number from Set_Drive_Schedule where  Academic_Year=@Academic_Year and Company_ID=@Company_ID and Drive_Title=@Drive_Title
			 end  
	 End

GO
CREATE proc [dbo].[SP_Student_Applied_Drive]
	@student_id int,
	@CompanyId [nvarchar](50),
	@CompanyName [nvarchar](50),
	@DriveTitle [nvarchar](50),
	@RegStartDate [nvarchar](50),
	@RegLastDate [nvarchar](50),
	@AppliedDate [nvarchar](50),
	@Approve [nvarchar](50)
	as
	begin
	insert into Student_Applied_Drive values(@student_id,@CompanyId,@CompanyName,@DriveTitle,@RegStartDate,@RegLastDate,@AppliedDate,@Approve)
	end

GO
CREATE procedure [dbo].[staff_add_update]
(
 @flag int,
 @emp_id nvarchar(10) = null,
 @fnm varchar(50) = null,
 @mnm varchar(50) = null,
 @lnm varchar (50) = null,
 @id_proof nvarchar(50) = null,
 @id_no varchar(18) = null,
 @gender varchar(15) = null,
 @dob nvarchar(50)=null,
 @city varchar(50) = null,
 @state varchar(50) = null,
 @pin varchar(6) = null,
 @address varchar(max) = null,
 @contact varchar(18) = null,
 @alt_contact_no varchar(18) = null,
 @email varchar(100) = null,
 @Designation nvarchar(50) = null,
 @Department nvarchar(50) = null,
 @status nvarchar(50) = null,
 @Joining_Date	varchar(50) = null

)
as
begin
	begin				/****** Member All Detail View ******/
		if(@flag=1)
			insert into emp_regi (fnm,mnm,lnm,id_proof,id_no,
			gender,dob,address,city,state,pin,contact,alt_contact_no ,email,Department,Designation,status,Joining_Date)
			 values(@fnm,@mnm ,@lnm,@id_no ,@id_proof,@gender ,@dob ,
			  @address ,@city ,@state ,@pin ,@contact ,@alt_contact_no,
			   @email,@Department,@Department,@status,@Joining_Date)   
			    
    end
    begin
		update  emp_regi set fnm=@fnm,mnm=@mnm,lnm=@lnm,
       id_proof=@id_proof,id_no=@id_no,gender=@gender,dob=@dob,
		address=@address ,city=@city ,state=@state ,pin=@pin ,contact=@contact ,
		alt_contact_no=@alt_contact_no ,email=@email,Department=@Department,status=@status where emp_id=@emp_id
	end
	begin				/****** Staff All Detail View where status='Active' ******/
 if(@flag=3)
	Select * from emp_regi where status='Active'
 end
  
 begin		/****** Staff Id Wise Detail View where status='Active' ******/
 if(@flag=4)
	Select * from emp_regi where emp_id=@emp_id and status='Active'
	
 end
 
 begin				/****** Staff All Detail View ******/
 if(@flag=5)
	Select * from emp_regi
 end
  
 begin				/****** Staff Id Wise Detail View ******/
 if(@flag=6)
	Select * from emp_regi where emp_id=@emp_id
	
 end
 begin				/****** Staff Id Wise Detail View ******/
 if(@flag=7)
	Select * from emp_regi where email=@email
	
 end

END

GO
CREATE procedure [dbo].[Student_add_update]    
(    
@flag int,  
@Stud_id nvarchar(50) =Null,
@Academic_Year nvarchar(50)=null,   
@Course_Name nvarchar(50)=null,  
@Aadhaar_No nvarchar(50)=null,  
@University_Reg_No nvarchar(50)=null,  
@Class_ID nvarchar(50)=null,  
@Roll_No nvarchar(50)=null,  
@Student_Name nvarchar(20)=null,  
@Email nvarchar(50)=null,  
@Contact_No nvarchar(50)=null,  
@alt_contact_no nvarchar(50)=null,  
@Mother_Name nvarchar(50)=null,  
@Gender nvarchar(50)=null,  
@DOB nvarchar(50)=null,  
@Blood_Group nvarchar(50)=null,  
@Mother_Tongue nvarchar(50)=null,  
@Languages nvarchar(50)=null,  
@Admission_Date nvarchar(50)=null,  
@Address nvarchar(50)=null,  
@Nationality nvarchar(50)=null,  
@Domicile nvarchar(50)=null,  
@Religion nvarchar(50)=null,  
@Category nvarchar(50)=null,  
@Caste nvarchar(50)=null,  
@Hostelite nvarchar(50)=null,  
@Handicap nvarchar(50)=null,  
@Sport nvarchar(50)=null,  
@Defence nvarchar(50)=null,  
@PAN_No nvarchar(50)=null,  
@Passport_No nvarchar(50)=null,  
@Driving_License nvarchar(50)=null,  
@F_Name nvarchar(50)=null,  
@F_Contact nvarchar(50)=null,  
@F_Email nvarchar(50)=null,  
@F_Occupation nvarchar(50)=null,  
@F_Organization nvarchar(50)=null,  
@F_Designation nvarchar(50)=null,  
@F_Address nvarchar(MAX)=null,  
@F_Annual_Income nvarchar(50)=null,  
@SSC_Board nvarchar(50)=null,  
@SSC_Institute nvarchar(50)=null,  
@SSC_Percentage nvarchar(50)=null,  
@SSC_Passed_Year nvarchar(50)=null,  
@SSC_Attempt nvarchar(50)=null,  
@HSC_Board nvarchar(50)=null,  
@HSC_Institute nvarchar(50)=null,  
@HSC_Percentage nvarchar(50)=null,  
@HSC_Passed_Year nvarchar(50)=null,  
@HSC_Attempt nvarchar(50)=null,  
@Diploma_Board nvarchar(50)=null,  
@Diploma_Institute nvarchar(50)=null,  
@Diploma_Percentage nvarchar(50)=null,  
@Diploma_Passed_Year nvarchar(50)=null,  
@Diploma_Attempt nvarchar(50)=null,  
@UG_Board nvarchar(50)=null,  
@UG_Institute nvarchar(50)=null,  
@UG_Percentage nvarchar(50)=null,  
@UG_Passed_Year nvarchar(50)=null,  
@UG_Attempt nvarchar(50)=null,  
@PG_Board nvarchar(50)=null,  
@PG_Institute nvarchar(50)=null,  
@PG_Percentage nvarchar(50)=null,  
@PG_Passed_Year nvarchar(50)=null,  
@PG_Attempt nvarchar(50)=null,  
@Sem1_Obtained_Marks nvarchar(50)=null,  
@Sem1_Total_Marks nvarchar(50)=null,  
@Sem1_Percentage nvarchar(50)=null,  
@Sem1_SGPA nvarchar(50)=null,  
@Sem1_BackLog nvarchar(50)=null,  
@Sem2_Obtained_Marks nvarchar(50)=null,  
@Sem2_Total_Marks nvarchar(50)=null,  
@Sem2_Percentage nvarchar(50)=null,  
@Sem2_SGPA nvarchar(50)=null,  
@Sem2_BackLog nvarchar(50)=null,  
@Sem3_Obtained_Marks nvarchar(50)=null,  
@Sem3_Total_Marks nvarchar(50)=null,  
@Sem3_Percentage nvarchar(50)=null,  
@Sem3_SGPA nvarchar(50)=null,  
@Sem3_BackLog nvarchar(50)=null,  
@Sem4_Obtained_Marks nvarchar(50)=null,  
@Sem4_Total_Marks nvarchar(50)=null,  
@Sem4_Percentage nvarchar(50)=null,  
@Sem4_SGPA nvarchar(50)=null,  
@Sem4_BackLog nvarchar(50)=null,  
@Sem5_Obtained_Marks nvarchar(50)=null,  
@Sem5_Total_Marks nvarchar(50)=null,  
@Sem5_Percentage nvarchar(50)=null,  
@Sem5_SGPA nvarchar(50)=null,  
@Sem5_BackLog nvarchar(50)=null,  
@Sem6_Obtained_Marks nvarchar(50)=null,  
@Sem6_Total_Marks nvarchar(50)=null,  
@Sem6_Percentage nvarchar(50)=null,  
@Sem6_SGPA nvarchar(50)=null,  
@Sem6_BackLog nvarchar(50)=null,  
@Sem7_Obtained_Marks nvarchar(50)=null,  
@Sem7_Total_Marks nvarchar(50)=null,  
@Sem7_Percentage nvarchar(50)=null,  
@Sem7_SGPA nvarchar(50)=null,  
@Sem7_BackLog nvarchar(50)=null,  
@Sem8_Obtained_Marks nvarchar(50)=null,  
@Sem8_Total_Marks nvarchar(50)=null,  
@Sem8_Percentage nvarchar(50)=null,  
@Sem8_SGPA nvarchar(50)=null,  
@Sem8_BackLog nvarchar(50)=null, 
@Year1_Obtained_Marks nvarchar(50)=null,  
@Year1_Total_Marks nvarchar(50)=null,  
@Year1_Percentage nvarchar(50)=null,  
@Year1_SGPA nvarchar(50)=null,  
@Year1_BackLog nvarchar(50)=null,  
@Year2_Obtained_Marks nvarchar(50)=null,  
@Year2_Total_Marks nvarchar(50)=null,  
@Year2_Percentage nvarchar(50)=null,  
@Year2_SGPA nvarchar(50)=null,  
@Year2_BackLog nvarchar(50)=null,  
@Year3_Obtained_Marks nvarchar(50)=null,  
@Year3_Total_Marks nvarchar(50)=null,  
@Year3_Percentage nvarchar(50)=null,  
@Year3_SGPA nvarchar(50)=null,  
@Year3_BackLog nvarchar(50)=null,  
@Year4_Obtained_Marks nvarchar(50)=null,  
@Year4_Total_Marks nvarchar(50)=null,  
@Year4_Percentage nvarchar(50)=null,  
@Year4_SGPA nvarchar(50)=null,  
@Year4_BackLog nvarchar(50)=null,  
@Year5_Obtained_Marks nvarchar(50)=null,  
@Year5_Total_Marks nvarchar(50)=null,  
@Year5_Percentage nvarchar(50)=null,  
@Year5_SGPA nvarchar(50)=null,  
@Year5_BackLog nvarchar(50)=null,
@Gap_Year nvarchar(50)=null,  
@Live_Backlogs nvarchar(50)=null,  
@Dead_Backlogs nvarchar(50)=null,  
@Experience nvarchar(50)=null,  
@Entrance_Score nvarchar(50)=null,  
@Aggregate nvarchar(50)=null,
/**** Student Project Details***/ 
@Project_Type	nvarchar(MAX) =Null,          
@Project_Title	nvarchar(MAX) =Null,          	
@Project_Domain	nvarchar(MAX) =Null,          	
@Project_Duration	nvarchar(MAX) =Null,          	
@Technologies	nvarchar(MAX) =Null,          	
@Team_Size	nvarchar(MAX) =Null,          	
@Guide_Name	nvarchar(MAX) =Null,          	
@Description	nvarchar(MAX) =Null 
/****end Project Details****/
)    
as    
begin    
  begin    /****** Member All Detail View ******/    
 if(@flag=1)    
   insert into Student_Registration   
           (Academic_Year,Course_Name,Aadhaar_No,University_Reg_No,Class_ID,Roll_No,Student_Name,Email,  
  Contact_No,alt_contact_no,Mother_Name,Gender,DOB,Blood_Group,Mother_Tongue,Languages,Admission_Date,  
  Address,Nationality,Domicile,Religion,Category,Caste,Hostelite,Handicap,Sport,Defence,PAN_No,  
  Passport_No,Driving_License,F_Name,F_Contact,F_Email,F_Occupation,F_Organization,F_Designation,  
  F_Address,F_Annual_Income,SSC_Board,SSC_Institute,SSC_Percentage,SSC_Passed_Year,SSC_Attempt,HSC_Board,  
  HSC_Institute,HSC_Percentage,HSC_Passed_Year,HSC_Attempt,Diploma_Board,Diploma_Institute,Diploma_Percentage,  
  Diploma_Passed_Year,Diploma_Attempt,UG_Board,UG_Institute,UG_Percentage,UG_Passed_Year,UG_Attempt,PG_Board,  
  PG_Institute,PG_Percentage,PG_Passed_Year,PG_Attempt,Sem1_Obtained_Marks,Sem1_Total_Marks,Sem1_Percentage,  
  Sem1_SGPA,Sem1_BackLog,Sem2_Obtained_Marks,Sem2_Total_Marks,Sem2_Percentage,Sem2_SGPA,Sem2_BackLog,  
  Sem3_Obtained_Marks,Sem3_Total_Marks,Sem3_Percentage,Sem3_SGPA,Sem3_BackLog,Sem4_Obtained_Marks,Sem4_Total_Marks,  
  Sem4_Percentage,Sem4_SGPA,Sem4_BackLog ,Sem5_Obtained_Marks,Sem5_Total_Marks,Sem5_Percentage,Sem5_SGPA,Sem5_BackLog,   
  Sem6_Obtained_Marks,Sem6_Total_Marks,Sem6_Percentage,Sem6_SGPA,Sem6_BackLog,Sem7_Obtained_Marks,Sem7_Total_Marks,  
  Sem7_Percentage,Sem7_SGPA,Sem7_BackLog ,Sem8_Obtained_Marks,Sem8_Total_Marks,Sem8_Percentage,Sem8_SGPA,  
  Sem8_BackLog,Year1_Obtained_Marks,Year1_Total_Marks,Year1_Percentage,  
  Year1_SGPA,Year1_BackLog,Year2_Obtained_Marks,Year2_Total_Marks,Year2_Percentage,  
  Year2_SGPA,Year2_BackLog,Year3_Obtained_Marks,Year3_Total_Marks,Year3_Percentage,  
  Year3_SGPA,Year3_BackLog,Year4_Obtained_Marks,Year4_Total_Marks,Year4_Percentage,  
  Year4_SGPA,Year4_BackLog,Year5_Obtained_Marks,Year5_Total_Marks,Year5_Percentage,  
  Year5_SGPA,Year5_BackLog,Gap_Year,Live_Backlogs,Dead_Backlogs,Experience,Entrance_Score,Aggregate)   
            Values (@Academic_Year,@Course_Name,@Aadhaar_No,@University_Reg_No,@Class_ID,@Roll_No,@Student_Name,@Email,  
  @Contact_No,@alt_contact_no,@Mother_Name,@Gender,@DOB,@Blood_Group,@Mother_Tongue,@Languages,@Admission_Date,  
  @Address,@Nationality,@Domicile,@Religion,@Category,@Caste,@Hostelite,@Handicap,@Sport,@Defence,@PAN_No,  
  @Passport_No,@Driving_License,@F_Name,@F_Contact,@F_Email,@F_Occupation,@F_Organization,@F_Designation,  
  @F_Address,@F_Annual_Income,@SSC_Board,@SSC_Institute,@SSC_Percentage,@SSC_Passed_Year,@SSC_Attempt,@HSC_Board,  
  @HSC_Institute,@HSC_Percentage,@HSC_Passed_Year,@HSC_Attempt,@Diploma_Board,@Diploma_Institute,@Diploma_Percentage,  
  @Diploma_Passed_Year,@Diploma_Attempt,@UG_Board,@UG_Institute,@UG_Percentage,@UG_Passed_Year,@UG_Attempt,@PG_Board,  
  @PG_Institute,@PG_Percentage,@PG_Passed_Year,@PG_Attempt,@Year1_Obtained_Marks,@Sem1_Total_Marks,@Sem1_Percentage,  
  @Sem1_SGPA,@Sem1_BackLog,@Sem2_Obtained_Marks,@Sem2_Total_Marks,@Sem2_Percentage,@Sem2_SGPA,@Sem2_BackLog,  
  @Sem3_Obtained_Marks,@Sem3_Total_Marks,@Sem3_Percentage,@Sem3_SGPA,@Sem3_BackLog,@Sem4_Obtained_Marks,@Sem4_Total_Marks,  
  @Sem4_Percentage,@Sem4_SGPA,@Sem4_BackLog ,@Sem5_Obtained_Marks,@Sem5_Total_Marks,@Sem5_Percentage,@Sem5_SGPA,@Sem5_BackLog,   
  @Sem6_Obtained_Marks,@Sem6_Total_Marks,@Sem6_Percentage,@Sem6_SGPA,@Sem6_BackLog,@Sem7_Obtained_Marks,@Sem7_Total_Marks,  
  @Sem7_Percentage,@Sem7_SGPA,@Sem7_BackLog ,@Sem8_Obtained_Marks,@Sem8_Total_Marks,@Sem8_Percentage,@Sem8_SGPA,  
  @Sem8_BackLog,@Year1_Obtained_Marks,@Year1_Total_Marks,@Year1_Percentage,  
  @Year1_SGPA,@Year1_BackLog,@Year2_Obtained_Marks,@Year2_Total_Marks,@Year2_Percentage,  
  @Year2_SGPA,@Year2_BackLog,@Year3_Obtained_Marks,@Year3_Total_Marks,@Year3_Percentage,  
  @Year3_SGPA,@Year3_BackLog,@Year4_Obtained_Marks,@Year4_Total_Marks,@Year4_Percentage,  
  @Year4_SGPA,@Year4_BackLog,@Year5_Obtained_Marks,@Year5_Total_Marks,@Year5_Percentage,  
  @Year5_SGPA,@Year5_BackLog,@Gap_Year,@Live_Backlogs,@Dead_Backlogs,@Experience,@Entrance_Score,@Aggregate)    
  end    
  begin    
 if(@flag=2)    
  update  Student_Registration set Academic_Year=@Academic_Year,Course_Name=@Course_Name,Aadhaar_No=@Aadhaar_No,  
    University_Reg_No=@University_Reg_No, Class_ID=@Class_ID,Roll_No=@Roll_No,Student_Name=@Student_Name,Email=@Email,  
  Contact_No=@Contact_No,alt_contact_no=@alt_contact_no,Mother_Name=@Mother_Name,Gender=@Gender,DOB=@DOB,Blood_Group=@Blood_Group,  
  Mother_Tongue=@Mother_Tongue,Languages=@Languages,Admission_Date=@Admission_Date,  
  Address=@Address,Nationality=@Nationality,Domicile=@Domicile,Religion=@Religion,Category=@Category,  
  Caste=@Caste,Hostelite=@Hostelite,Handicap=@Handicap,Sport=@Sport,Defence=@Defence,PAN_No=@PAN_No,  
  Passport_No=@Passport_No,Driving_License=@Driving_License,F_Name=@F_Name,F_Contact=@F_Contact,F_Email=@F_Email,  
  F_Occupation=@F_Occupation,F_Organization=@F_Organization,F_Designation=@F_Designation,  
  F_Address=@F_Address,F_Annual_Income=@F_Annual_Income,SSC_Board=@SSC_Board,SSC_Institute=@SSC_Institute,  
  SSC_Percentage=@SSC_Percentage,SSC_Passed_Year=@SSC_Passed_Year,SSC_Attempt=@SSC_Attempt,HSC_Board=@HSC_Board,  
  HSC_Institute=@HSC_Institute,HSC_Percentage=@HSC_Percentage,HSC_Passed_Year=@HSC_Passed_Year,  
  HSC_Attempt=@HSC_Attempt,Diploma_Board=@Diploma_Board,Diploma_Institute=@Diploma_Institute,Diploma_Percentage=@Diploma_Percentage,  
  Diploma_Passed_Year=@Diploma_Passed_Year,Diploma_Attempt=@Diploma_Attempt,UG_Board=@UG_Board,  
  UG_Institute=@UG_Institute,UG_Percentage=@UG_Percentage,UG_Passed_Year=@UG_Passed_Year,UG_Attempt=@UG_Attempt,PG_Board=@PG_Board,  
  PG_Institute=@PG_Institute,PG_Percentage=@PG_Percentage,PG_Passed_Year=@PG_Passed_Year,  
  PG_Attempt=@PG_Attempt,Sem1_Obtained_Marks=@Sem1_Obtained_Marks,Sem1_Total_Marks=@Sem1_Total_Marks,Sem1_Percentage=@Sem1_Percentage,  
  Sem1_SGPA=@Sem1_SGPA,Sem1_BackLog=@Sem1_BackLog,Sem2_Obtained_Marks=@Sem2_Obtained_Marks,  
  Sem2_Total_Marks=@Sem2_Total_Marks,Sem2_Percentage=@Sem2_Percentage,Sem2_SGPA=@Sem2_SGPA,Sem2_BackLog=@Sem2_BackLog ,  
  Sem3_Obtained_Marks=@Sem3_Obtained_Marks,Sem3_Total_Marks=@Sem3_Total_Marks,Sem3_Percentage=@Sem3_Percentage,  
  Sem3_SGPA=@Sem3_SGPA,Sem3_BackLog=@Sem3_BackLog,Sem4_Obtained_Marks=@Sem4_Obtained_Marks,Sem4_Total_Marks=@Sem4_Total_Marks ,  
  Sem4_Percentage=@Sem4_Percentage,Sem4_SGPA=@Sem4_SGPA,Sem4_BackLog=@Sem4_BackLog,Sem5_Obtained_Marks=@Sem5_Obtained_Marks,  
  Sem5_Total_Marks=@Sem5_Total_Marks,Sem5_Percentage=@Sem5_Percentage,Sem5_SGPA=@Sem5_SGPA,Sem5_BackLog=@Sem5_BackLog,   
  Sem6_Obtained_Marks=@Sem6_Obtained_Marks,Sem6_Total_Marks=@Sem6_Total_Marks,Sem6_Percentage=@Sem6_Percentage,  
  Sem6_SGPA=@Sem6_SGPA,Sem6_BackLog=@Sem6_BackLog,  
  Sem7_Obtained_Marks=@Sem7_Obtained_Marks,Sem7_Total_Marks=@Sem7_Total_Marks ,  
  Sem7_Percentage=@Sem7_Percentage,Sem7_SGPA=@Sem7_SGPA,Sem7_BackLog=@Sem7_BackLog,Sem8_Obtained_Marks=@Sem8_Obtained_Marks,  
  Sem8_Total_Marks=@Sem8_Total_Marks,Sem8_Percentage=@Sem8_Percentage,Sem8_SGPA=@Sem8_SGPA,  
 Sem8_BackLog=@Sem8_BackLog,
 Year1_Obtained_Marks=@Year1_Obtained_Marks,Year1_Total_Marks=@Year1_Total_Marks,Year1_Percentage=@Year1_Percentage,  
  Year1_SGPA=@Year1_SGPA,Year1_BackLog=@Year1_BackLog,Year2_Obtained_Marks=@Year2_Obtained_Marks,Year2_Total_Marks=@Year2_Total_Marks,Year2_Percentage=@Year2_Percentage,  
  Year2_SGPA=@Year2_SGPA,Year2_BackLog=@Year2_BackLog,Year3_Obtained_Marks=@Year3_Obtained_Marks,Year3_Total_Marks=@Year3_Total_Marks,Year3_Percentage=@Year3_Percentage,  
  Year3_SGPA=@Year3_SGPA,Year3_BackLog=@Year3_BackLog,Year4_Obtained_Marks=@Year4_Obtained_Marks,Year4_Total_Marks=@Year4_Total_Marks,Year4_Percentage=@Year4_Percentage,  
  Year4_SGPA=@Year4_SGPA,Year4_BackLog=@Year4_BackLog,Year5_Obtained_Marks=@Year5_Obtained_Marks,Year5_Total_Marks=@Year5_Total_Marks,Year5_Percentage=@Year5_Percentage,  
  Year5_SGPA=@Year5_SGPA,Year5_BackLog=@Year5_BackLog,Gap_Year=@Gap_Year,Live_Backlogs=@Live_Backlogs,Dead_Backlogs=@Dead_Backlogs,
 Experience=@Experience,Entrance_Score=@Entrance_Score,Aggregate=@Aggregate where Student_ID=@Stud_id    
  end    
  begin    /****** Member All Detail View ******/    
 if(@flag=3)   
  
  select * from Student_Registration where Student_ID=@Stud_id  
  end   
   begin    /****** Member All Detail View ******/    
 if(@flag=4)   
  
  select * from Student_Registration 
  end 
  
    begin    /****** Member All Detail View ******/    
 if(@flag=5)   
  
  select * from Student_Registration where Academic_Year=@Academic_Year and Course_Name=@Course_Name
  end 
  
 /******Add Student Project Detail ******/
   begin    
 if(@flag=6) 
   insert into Stud_Project_Details(Student_ID,Project_Type,Project_Title,Project_Domain,
       Project_Duration,Technologies,Team_Size,Guide_Name,Description)
       values(@Stud_id,@Project_Type,@Project_Title,@Project_Domain,@Project_Duration,
       @Technologies,@Team_Size,@Guide_Name,@Description)       
  end       
        begin          
      if(@flag=7) 
       
        update Stud_Project_Details set Project_Type=@Project_Type,Project_Title=@Project_Title,
         Project_Domain=@Project_Domain,Project_Duration=@Project_Duration,Technologies=@Technologies,
        Team_Size=@Team_Size,Guide_Name=@Guide_Name,Description=@Description where Student_ID=@Stud_id
   
    end          
  begin          
      if(@flag=8)                   
                  
         select* from  Stud_Project_Details           
         end          
                   
    begin          
    if(@flag=9)           
              
    select* from  Stud_Project_Details where Student_ID=@Stud_id and Project_Title=@Project_Title
    end  
     /****** end Add Student Project Detail ******/
        
   
END    

GO
CREATE procedure [dbo].[user_login] 
(
 @username nvarchar(50),
 @password nvarchar(50)
) 
as
begin
Declare @count int

select @count=COUNT(username) from Placement_Login where username=@username and login_password= @password 

if (@count=1)
begin
select 1 as returncode
END
else 
Begin
Select -1 as returncode
END

end
go
  insert into Placement_Login values 
  ('principle@gmail.com', 'Welcome@123', 'Principal', 'Active'),
  ('admin@gmail.com', 'Welcome@123', 'Admin', 'Active'),
  ('hod@gmail.com', 'Welcome@123', 'HOD', 'Active'),
  ('coordinator@gmail.com', 'Welcome@123', 'Coordinator', 'Active'),
  ('company@gmail.com', 'Welcome@123', 'Company', 'Active'),
  ('student@gmail.com', 'Welcome@123', 'Student', 'Active')
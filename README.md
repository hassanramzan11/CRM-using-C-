__Create the Database in your Local Server__
add new Table name Product and paste this command into the SQL
## Product Table
```sql
CREATE TABLE [dbo].[Product] (
    [Product_ID]        INT           IDENTITY (1, 1) NOT NULL,
    [Product_Key]       INT           NOT NULL,
    [Product_Name]      VARCHAR (255) NOT NULL,
    [Product_Reference] VARCHAR (50)  NOT NULL,
    [Product_Desc]      TEXT          NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Product_ID] ASC)
);
```
## Admin Table
```sql
add new Table name admin and paste this command into the SQL
CREATE TABLE [dbo].[admin] (
    [UserId]      INT           IDENTITY (1, 1) NOT NULL,
    [Username]    VARCHAR (255) NOT NULL,
    [Email]       VARCHAR (255) NOT NULL,
    [PhoneNumber] VARCHAR (15)  NOT NULL,
    [Password]    VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);
```
## CustomerReviews Table
```sql
add new Table name CustomerReviews and paste this command into the SQL
CREATE TABLE [dbo].[CustomerReviews] (
    [CustomerId]     INT           NOT NULL,
    [CustomerName]   VARCHAR (255) NOT NULL,
    [PhoneNo]        VARCHAR (15)  NOT NULL,
    [Email]          VARCHAR (255) NOT NULL,
    [CustomerReview] TEXT          NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)



);
```
__And you are good to go 😊__

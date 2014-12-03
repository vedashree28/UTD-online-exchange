CREATE PROCEDURE [dbo].[updateWishlist]
	@p_id int,
	@item_id int,
	@user_id varchar(50)
AS
begin

update WishList_Items
set isFulfilled = 'Y', P_ID = @p_id
where  Item_ID = @item_id and USER_ID = @user_id

end
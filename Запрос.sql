SELECT pr.ProductName, ct.CategoryName FROM
Products pr with(nolock)
left join
Collection cl with(nolock)
on cl.ProductsID = pr.ID
left join
Categories ct with(nolock)
on cl.CategoriesID = ct.ID
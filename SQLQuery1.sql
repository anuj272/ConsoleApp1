select  * from Account
select * from Product 
select * from BINProduct
select * from BIN
BINType
select top 1 * from Processor

GetProxyByAccountIdentifier 'E6D34F13-8919-4E62-81E5-8A310BBE6C4E'
GetProcessorByAccountIdentifier 'E6D34F13-8919-4E62-81E5-8A310BBE6C4E'

select * from Account where AccountIdentifier = 'E6D34F13-8919-4E62-81E5-8A310BBE6C4E'
update account set ProductKey = 5 where AccountIdentifier = 'E6D34F13-8919-4E62-81E5-8A310BBE6C4E'

  FROM dbo.Account a
        inner join dbo.Product p on a.ProductKey = p.ProductKey
		inner join dbo.BINProduct bp on p.ProductKey = bp.ProductKey
		inner join dbo.BIN b on bp.BINKey = b.BINKey
		inner join dbo.Processor pc on b.ProcessorKey = pc.ProcessorKey
    WHERE a.AccountIdentifier = @AccountIdentifier


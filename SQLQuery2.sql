
	SELECT h.Hotel_No, h.Name, r.Room_No, r.Types, r.Price
	 FROM hotel h
	 inner join Room r
	 on h.Hotel_No = r.Hotel_No

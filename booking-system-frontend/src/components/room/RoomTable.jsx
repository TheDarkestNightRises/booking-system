import "./Table.css";
import { useState } from "react";
import useFetch from "../../hooks/useFetch";
import RoomTableRow from "./RoomTableRow";
import RoomTablePopup from "../reservation/ReservationPopup";

function RoomTable() {
  const [showPopup, setShowPopup] = useState(null);

  const handlePopupOpen = (room) => {
    setShowPopup(room);
  };

  const handlePopupClose = () => {
    setShowPopup(null);
  };

  const { data: rooms, isLoading, error } = useFetch("rooms");

  if (isLoading) {
    return <div>Loading...</div>;
  }

  if (error) {
    return <div>Error: {error.message}</div>;
  }

  return (
    <div className="container">
      <table className="room-table">
        <thead>
          <tr>
            <th>Room</th>
            <th>Quantity</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          {rooms.map((room) => (
            <RoomTableRow room={room} onClick={() => handlePopupOpen(room)} />
          ))}
        </tbody>
      </table>
      {showPopup && (
        <RoomTablePopup room={showPopup} onClose={handlePopupClose} />
      )}
    </div>
  );
}

export default RoomTable;

import "./Table.css";

function RoomTableRow({ room, onClick }) {
  return (
    <>
      <tr>
        <td>{room.name}</td>
        <td>{room.numberOfPeople}</td>
        <td>
          <button onClick={onClick}>Reserve</button>
        </td>
      </tr>
    </>
  );
}
export default RoomTableRow;

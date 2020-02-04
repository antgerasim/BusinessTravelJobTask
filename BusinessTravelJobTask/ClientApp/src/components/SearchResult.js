import React, { Component } from 'react';

export class SearchResult extends Component {

    constructor(props) {
        super(props);

        /*         this.state = {
                }; */
    }

    render() {
        const error = this.props.error;
        const items = this.props.items;
        const isLoaded = this.props.isLoaded;

        if (error) {
            return <div>Error: {error.message}</div>;
        } else {
            console.log("isLoaded: ", isLoaded);
            if (!isLoaded) {
                return <div>Loading...</div>;
            }
            console.log("API Search Result:");
            console.log(items);
            if (!items === undefined || items.length !== 0) {
                return (
                    <div>
                        <h1>Найдено {items.length} отелей</h1>
                        <table>
                            <thead>
                                <tr>
                                    <th>Дата</th>
                                    <th>Название отеля</th>
                                    <th>Название номера</th>
                                    <th>Название питания</th>
                                    <th>Стоимость</th>
                                </tr>
                            </thead>
                            <tbody>
                                {items.map(
                                    (item, index) =>
                                        <tr key={index}>
                                            <td >{item.tourDate}</td>
                                            <td >{item.hotelName}</td>
                                            <td >{item.roomName}</td>
                                            <td >{item.mealType}</td>
                                            <td ><span>{item.price}</span> <span>{item.currency}</span></td>
                                        </tr>
                                )
                                }
                            </tbody>
                        </table>
                    </div>
                );
            }
            else {
                return (
                    <div>
                        {/*                         <h1>Результат поиска</h1>
                        <p>Поиск не вернул никаких результатов</p> */}
                    </div>
                );
            }
        }
    }
}
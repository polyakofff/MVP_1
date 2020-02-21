using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_1 {
    class Presenter {
        private Model model = new Model();
        private IView view;

        public Presenter(IView view) {
            this.view = view;
            this.view.OnSetFahrenheit += new EventHandler<EventArgs>(SetFahrenheit);
            this.view.OnSetCelsius += new EventHandler<EventArgs>(SetCelsius);
            UpdateView();
        }

        private void SetFahrenheit(object sender, EventArgs args) {
            model.ValueFahrenheit = view.InputDegrees;
            UpdateView();
        }

        private void SetCelsius(object sender, EventArgs args) {
            model.ValueCelsius = view.InputDegrees;
            UpdateView();
        }

        private void UpdateView() {
            view.PrintFahrenheit(model.ValueFahrenheit);
            view.PrintCelsius(model.ValueCelsius);
        }
    }
}

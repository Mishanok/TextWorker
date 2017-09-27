using System;
using System.Windows.Forms;
using TextWorker.BL;

namespace TextWorker
{
    class MainPresenter
    {
        private readonly IMainForm _form;
        private readonly IFileManager _manager;
        private readonly IMEssageService _service;
        private readonly IChanger _changer;

        private string currentFilepath;

        public MainPresenter(IMainForm form, IFileManager manager, IMEssageService service, IChanger changer)
        {
            _form = form;
            _manager = manager;
            _service = service;
            _changer = changer;

            _form.FileOpenClick += _form_FileOpenClick;
            _form.FileSaveClick += _form_FileSaveClick;
            _form.ContClearClick += _form_ContClearClick;
            _form.ContDelLinesClick += _form_ContDelLinesClick;
            _form.ContDestEngClick += _form_ContDestEngClick;
            _form.ContMakeLinesClick += _form_ContMakeLinesClick;
        }

        private void _form_ContMakeLinesClick(object sender, EventArgs e)
        {
            try
            {
                
                var lines = _form.Lines;
                if (lines == null) _service.ShowExlamation("Помістіть спочатку текст!");
                var sym = _form.Sym;
                if (sym == "" || sym == null)
                {
                    _service.ShowExlamation("Не введено символ!");
                }
                else
                if (sym.Length > 1) _service.ShowExlamation("Символ повинен бути один!");
                else
                {
                    var res = _changer.MakeLines(sym, lines);
                    _form.Lines = res;
                    _service.ShowMessage("Нові рядки успішно сформовані!");
                }
            }
           catch (Exception ex) { _service.ShowError(ex.Message); }
        }

        private void _form_ContDestEngClick(object sender, EventArgs e)
        {
            try
            {
                var lines = _form.Lines;
                if (lines == null) _service.ShowExlamation("Спочатку помістіть текст!");
                var res = _changer.DestEng(lines);
                _form.Lines = res;
            }
            catch (Exception ex) { _service.ShowError(ex.Message); }

        }

        private void _form_ContDelLinesClick(object sender, int e)
        {
            try
            {
                var lines = _form.Lines;
                if (lines == null) { _service.ShowExlamation("Помістіть спочатку текст!"); }
                else
                {
                    var res = _changer.DelLines(e, lines);
                    _form.Lines = res;
                    _service.ShowMessage("Залишено лише рядки потрібного розміру!");
                }                         
            }
            catch(Exception ex)
            {
                _service.ShowError(ex.Message);
            }
        }

        private void _form_ContClearClick(object sender, EventArgs e)
        {
            try
            {
                var line = _form.Delet.ToString();
                var content = _form.Content;
                var lines = _form.Lines;
                string[] res = _changer.ClearText(line, content, lines);
                _form.Lines = res;
                _service.ShowMessage("Непотрібні рядки успішно видалено!");
            }
            catch(Exception ex)
            {
                _service.ShowError(ex.Message);
            }
        }

        private void _form_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                if (currentFilepath != null)
                {
                    string content = _form.Content;
                    _manager.SaveText(content, currentFilepath);
                    _service.ShowMessage("Файл успішно збережено!");
                }
            }
            catch (Exception ex)
            {
                _service.ShowError(ex.Message);
            }
        }

        private void _form_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filepath = _form.FilePath;

                bool isExist = _manager.IsExist(filepath);

                if (!isExist)
                {
                    _service.ShowExlamation("Вибраного файлу не існує!");
                    return;
                }

                 currentFilepath = filepath;

                string content = _manager.GetText(filepath);
                _form.Content = content;
            }

            catch(Exception ex)
            {
                _service.ShowError(ex.Message);
            }
        }
    }
}

const form = document.querySelector("#animal-form");
const list = document.querySelector("#animal-list");
const notice = document.querySelector("#aviso");
const submitButton = document.querySelector("#submit-button");
const cancelButton = document.querySelector("#cancel-edit");
let editingCode = null;
let noticeTimer;

function showNotice(message, isError = false) {
  notice.textContent = message;
  notice.classList.toggle("error", isError);
  notice.hidden = false;
  clearTimeout(noticeTimer);
  noticeTimer = setTimeout(() => { notice.hidden = true; }, 5000);
}

async function request(url, options = {}) {
  const response = await fetch(url, {
    ...options,
    headers: { "Content-Type": "application/json", ...options.headers }
  });
  if (!response.ok) {
    let message = `Ocorreu um erro (${response.status}).`;
    try { message = (await response.json()).erro || message; } catch { /* resposta sem JSON */ }
    throw new Error(message);
  }
  return response.status === 204 ? null : response.json();
}

function addCell(row, value) {
  const cell = document.createElement("td");
  cell.textContent = value;
  row.append(cell);
  return cell;
}

function resetForm() {
  form.reset();
  form.elements.codigo.disabled = false;
  form.elements.idade.value = "0";
  editingCode = null;
  submitButton.textContent = "Cadastrar animal";
  cancelButton.hidden = true;
  document.querySelector("#form-title").textContent = "Cadastrar animal";
}

async function loadAnimals() {
  const params = new URLSearchParams();
  const term = document.querySelector("#termo").value.trim();
  if (term) {
    params.set("termo", term);
    params.set("campo", document.querySelector("#campo").value);
  }

  try {
    const animals = await request(`/api/animais?${params}`);
    document.querySelector("#total").textContent = animals.length;
    list.replaceChildren();
    if (!animals.length) {
      const row = document.createElement("tr");
      const cell = addCell(row, "Nenhum animal encontrado.");
      cell.colSpan = 6;
      cell.className = "empty";
      list.append(row);
      return;
    }

    for (const animal of animals) {
      const row = document.createElement("tr");
      addCell(row, animal.codigo);
      addCell(row, animal.nome);
      addCell(row, `${animal.especie} / ${animal.raca}`);
      addCell(row, animal.idade === 1 ? "1 ano" : `${animal.idade} anos`);
      addCell(row, animal.nomeResponsavel);

      const actions = document.createElement("td");
      actions.className = "actions";
      const edit = document.createElement("button");
      edit.type = "button";
      edit.className = "text-button";
      edit.textContent = "Editar";
      edit.addEventListener("click", () => startEdit(animal));
      const remove = document.createElement("button");
      remove.type = "button";
      remove.className = "text-button delete-button";
      remove.textContent = "Excluir";
      remove.addEventListener("click", () => deleteAnimal(animal));
      actions.append(edit, remove);
      row.append(actions);
      list.append(row);
    }
  } catch (error) {
    list.replaceChildren();
    const row = document.createElement("tr");
    const cell = addCell(row, "Não foi possível carregar os cadastros. Verifique a conexão e tente novamente.");
    cell.colSpan = 6;
    cell.className = "empty";
    list.append(row);
    showNotice(error.message, true);
  }
}

function startEdit(animal) {
  editingCode = animal.codigo;
  form.elements.codigo.value = animal.codigo;
  form.elements.codigo.disabled = true;
  form.elements.nome.value = animal.nome;
  form.elements.especie.value = animal.especie;
  form.elements.raca.value = animal.raca;
  form.elements.idade.value = animal.idade;
  form.elements.nomeResponsavel.value = animal.nomeResponsavel;
  submitButton.textContent = "Salvar alterações";
  cancelButton.hidden = false;
  document.querySelector("#form-title").textContent = `Editar animal #${animal.codigo}`;
  form.scrollIntoView({ behavior: "smooth", block: "start" });
}

async function deleteAnimal(animal) {
  if (!confirm(`Deseja excluir o animal "${animal.nome}"?`)) return;
  try {
    await request(`/api/animais/${animal.codigo}`, { method: "DELETE" });
    showNotice("Animal excluído com sucesso.");
    await loadAnimals();
  } catch (error) {
    showNotice(error.message, true);
  }
}

form.addEventListener("submit", async (event) => {
  event.preventDefault();
  const animal = {
    codigo: Number(form.elements.codigo.value),
    nome: form.elements.nome.value.trim(),
    especie: form.elements.especie.value.trim(),
    raca: form.elements.raca.value.trim(),
    idade: Number(form.elements.idade.value),
    nomeResponsavel: form.elements.nomeResponsavel.value.trim()
  };
  try {
    if (editingCode === null) {
      await request("/api/animais", { method: "POST", body: JSON.stringify(animal) });
      showNotice("Animal cadastrado com sucesso.");
    } else {
      await request(`/api/animais/${editingCode}`, { method: "PUT", body: JSON.stringify(animal) });
      showNotice("Cadastro atualizado com sucesso.");
    }
    resetForm();
    await loadAnimals();
  } catch (error) {
    showNotice(error.message, true);
  }
});

document.querySelector("#filter-form").addEventListener("submit", (event) => {
  event.preventDefault();
  loadAnimals();
});
document.querySelector("#clear-filter").addEventListener("click", () => {
  document.querySelector("#termo").value = "";
  document.querySelector("#campo").value = "nome";
  loadAnimals();
});
cancelButton.addEventListener("click", resetForm);
loadAnimals();
